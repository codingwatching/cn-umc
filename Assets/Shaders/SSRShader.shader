Shader "CustomEffects/SSREffect"
{
    
     
           
 
 
  Properties {
        _MainTex ("Base (RGB)", 2D) = "" {}
    }

    
    
   
    
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline"}
        LOD 100
        ZWrite Off Cull Off
        Pass
        {
            Name "SSRQuad"

            HLSLPROGRAM
            
         #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"  
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"  
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareNormalsTexture.hlsl"  
         #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl" 
        #include "Packages/com.unity.render-pipelines.core/Runtime/Utilities/Blit.hlsl"

           
              #pragma vertex Vert
              #pragma fragment SSRPassFragment
            uniform matrix matView;
            uniform matrix matProjection;
            uniform matrix matInverseView;
            uniform matrix matInverseProjection;
            uniform float3 CameraPos;
             uniform float4 _ProjectionParams2;
            uniform float4 _CameraViewTopLeftCorner;
            uniform float4 _CameraViewXExtent;
            uniform float4 _CameraViewYExtent;
                
            uniform float StrideSize;
            uniform float SSRThickness;
            uniform int StepCount;
            uniform float FadeDistance;
            half3 ReconstructViewPos(float2 uv, float linearEyeDepth) {  
                // Screen is y-inverted  
                uv.y = 1.0 - uv.y;  

                float zScale = linearEyeDepth * _ProjectionParams2.x; // divide by near plane  
                float3 viewPos = _CameraViewTopLeftCorner.xyz + _CameraViewXExtent.xyz * uv.x + _CameraViewYExtent.xyz * uv.y;  
                viewPos *= zScale;  
                return viewPos;  
            }
            half3 ReconstructViewPosMatrix(float2 uv, float rawDepth) {  
                // Screen is y-inverted  
           //     uv.y = 1.0 - uv.y;  
                #if UNITY_REVERSED_Z
                    rawDepth = SampleSceneDepth(uv);
                #else
                    //  调整 Z 以匹配 OpenGL 的 NDC ([-1, 1])
                    rawDepth= lerp(UNITY_NEAR_CLIP_VALUE, 1, SampleSceneDepth(uv));
                #endif
                float3 worldPos = ComputeWorldSpacePosition(uv, rawDepth, UNITY_MATRIX_I_P);
                return worldPos;
            }

            void ReconstructUVAndDepthMatrix(float3 wpos, out float2 uv, out float depth) {  
                float4 cpos = mul(UNITY_MATRIX_P, wpos);  
                uv = float2(cpos.x, cpos.y) / cpos.w * 0.5 + 0.5;  
                depth = cpos.z/cpos.w;  
            }

            void ReconstructUVAndDepth(float3 wpos, out float2 uv, out float depth) {  
                float4 cpos = mul(UNITY_MATRIX_VP, wpos);  
                uv = float2(cpos.x, cpos.y * _ProjectionParams.x) / cpos.w * 0.5 + 0.5;  
                depth = cpos.w;  
            }
            half4 GetSource(half2 uv) {  
                return SAMPLE_TEXTURE2D_X_LOD(_BlitTexture, sampler_LinearRepeat, uv, _BlitMipLevel);  
            }



            float3 GetUVFromPosition(float3 worldPos)
            {
                float4 cpos = mul(worldPos, UNITY_MATRIX_VP);
                float2 uv = float2(cpos.x, cpos.y  * _ProjectionParams.x) / cpos.w * 0.5 + 0.5;  
                 float depth=cpos.w;
                return float3(uv.xy,depth);
            }

            float3 GetWorldPosition(float2 vTexCoord, float depth)
            {
              #if UNITY_REVERSED_Z
                    depth = SampleSceneDepth(vTexCoord);
                #else
                    //  调整 Z 以匹配 OpenGL 的 NDC ([-1, 1])
                    depth= lerp(UNITY_NEAR_CLIP_VALUE, 1, SampleSceneDepth(vTexCoord));
                #endif
                float3 worldPos = ComputeWorldSpacePosition(vTexCoord, depth, UNITY_MATRIX_I_VP);
                return worldPos;
            }
            half4 SSRPassFragment(Varyings input) : SV_Target {  
                float rawDepth = SampleSceneDepth(input.texcoord);  
                float linearDepth = LinearEyeDepth(rawDepth, _ZBufferParams);  
                float3 vpos = ReconstructViewPos(input.texcoord, linearDepth);  
                float3 vnormal = SampleSceneNormals(input.texcoord);  
                float3 wPos=GetWorldPosition(input.texcoord,rawDepth).xyz;

                float3 vDir = normalize(wPos-CameraPos);  
                 float diff = max(dot(vnormal, vDir), -1.0);
                if (diff >= -0.3)
                {
                return float4(0,0,0,1);
                }
                float3 rDir = normalize(reflect(vDir, vnormal));  

                
                 bool hit=false;
                 float curLength=StrideSize;
                 float3 curPos=vpos;
                float2 uv1;
                float resultDepth;
                UNITY_LOOP
                 for (int i = 0;i <StepCount; i++)
                        {
                    // Has it hit anything yet
                        if (hit == false)
                        {
                        // Update the Current Position of the Ray
                        curPos +=rDir *curLength;
                        if(length(curPos)>FadeDistance){
                        return float4(0,0,0,1);
                        }
                        // Get the UV Coordinates of the current Ray
                        ReconstructUVAndDepth(curPos,uv1,resultDepth);
                        // The Depth of the Current Pixel
                        float sampleDepth = LinearEyeDepth(SampleSceneDepth(uv1), _ZBufferParams);
             
                            if (resultDepth>sampleDepth &&resultDepth < sampleDepth +SSRThickness )
                            {
                                // If it's hit something, then return the UV position
                              if(uv1.x<0||uv1.x>1||uv1.y<0||uv1.y>1){
                                 return float4(0,0,0,1);
                              }
                                return GetSource(uv1);
                            }
                        if (resultDepth < 0.00001||sampleDepth<0.00001)
                        {
                                // If it's hit something, then return the UV position
                             
                            return float4(0,0,0,1);
                        }
                           // curDepth = GetDepth(curUV.xy + (float2(0.01, 0.01) * 2));
           

                        // Get the New Position and Vector
                        
                    }
                    }
              //  ReconstructUVAndDepth(vpos,uv,depth);
              //  ReconstructUVAndDepthMatrix(ReconstructViewPosMatrix(input.texcoord,linearDepth),uv,depth);
              //  return float4(uv.xy,1,1);
             //   UNITY_LOOP
              //  for (int i = 0; i < 16; i++) {  
              //  float3 vpos2 = vpos + rDir * 1 * i;  
              //  float2 uv2;  
             //   float stepDepth;  
             //   ReconstructUVAndDepth(vpos2, uv2, stepDepth);  
             //   float stepRawDepth = SampleSceneDepth(uv2);  
             //   float stepSurfaceDepth = LinearEyeDepth(stepRawDepth, _ZBufferParams);  
             //   if (stepSurfaceDepth < stepDepth && stepDepth < stepSurfaceDepth + 0.1 )  {
             //    if(uv2.x<0||uv2.x>1||uv2.y<0||uv2.y>1){
            //    return float4(0,0,0,1);
             //   }
            //    return GetSource(uv2);  
            //    }
               
                       
            //    }    
                return half4(0.0, 0.0, 0.0, 1.0);  
            }






            ENDHLSL
        }
        
        Pass
        {
         Name "Blending"

         ZTest NotEqual
        ZWrite Off
        Cull Off
        Blend One One, One Zero
         HLSLPROGRAM
            
         #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"  
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"  
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareNormalsTexture.hlsl"  
         #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl" 
        #include "Packages/com.unity.render-pipelines.core/Runtime/Utilities/Blit.hlsl"

             
              #pragma vertex Vert
              #pragma fragment Blending
              half4 GetSource(half2 uv) {  
                return SAMPLE_TEXTURE2D_X_LOD(_BlitTexture, sampler_LinearRepeat, uv, _BlitMipLevel);  
                }
              
              float4 Blending(Varyings input):SV_Target{
             
              return GetSource(input.texcoord);
              }

              ENDHLSL
        
        }
        
    }
}