﻿using System.Collections.Generic;
using UnityEngine;


public static partial class VoxelCast
    {

    //    public static VisualizationLine line = new VisualizationLine(null, new Vector3(0, 0, 0), new Vector3(0, 1, 0), 1, new Color(1, 1, 1));
        public static Dictionary<Vector3Int,SimpleAxisAlignedBB> blockBoundsTmp =new Dictionary<Vector3Int, SimpleAxisAlignedBB>();
        public static void Cast(VoxelWorldRay ray, int radius, out Vector3Int result, out BlockFaces resultFaces)
        {
            //     blocksTmp.Clear();

            float minDist = 10000f;
            resultFaces = BlockFaces.PositiveY;
            result = new Vector3Int(-1, -1, -1);
            Vector3 originAligned = ChunkCoordsHelper.Vec3ToBlockPos(ray.origin) + new Vector3(0.5f, 0.5f, 0.5f);
            for (int i = -radius + 1; i < radius; i++)
            {
                for (int j = -radius + 1; j < radius; j++)
                {
                    for (int k = -radius + 1; k < radius; k++)
                    {
                        Vector3Int blockPos = ChunkCoordsHelper.Vec3ToBlockPos(new Vector3(originAligned.x + i, originAligned.y + j, originAligned.z + k));
                        SimpleAxisAlignedBB blockBounds;
                        
                            BlockData data = WorldUpdateablesMediator.instance.GetBlockData(blockPos);


                            blockBounds = BlockBoundingBoxUtility.GetBoundingBoxSelectable(blockPos.x, blockPos.y, blockPos.z, data);
                        
                        


                    //     blocksTmp.Add(blockBounds);
                    BlockFaces face1 = BlockFaces.PositiveY;
                        float? resultDis = ray.Intersects(blockBounds, out face1);

                        //  Debug.WriteLine(resultDis != null);
                        if (resultDis != null)
                        {
                            if (minDist > resultDis.Value)
                            {
                                result = blockPos;
                                resultFaces = face1;
                                minDist = resultDis.Value;
                            }

                        }
                    }
                }
            }

            //   Debug.WriteLine(result);
        }

        public static void CastSpecificArea(VoxelWorldRay ray,Vector3 areaOrigin, int radius, out Vector3Int result, out BlockFaces resultFaces)
        {
            //     blocksTmp.Clear();

            float minDist = 10000f;
            resultFaces = BlockFaces.PositiveY;
            result = new Vector3Int(-1, -1, -1);
            Vector3 originAligned = ChunkCoordsHelper.Vec3ToBlockPos(areaOrigin) + new Vector3(0.5f, 0.5f, 0.5f);
            for (int i = -radius; i <=radius; i++)
            {
                for (int j = -radius ; j <= radius; j++)
                {
                    for (int k = -radius; k <= radius; k++)
                    {
                        Vector3Int blockPos = ChunkCoordsHelper.Vec3ToBlockPos(new Vector3(originAligned.x + i, originAligned.y + j, originAligned.z + k));
                        SimpleAxisAlignedBB blockBounds;

                        BlockData data = WorldUpdateablesMediator.instance.GetBlockData(blockPos);


                        blockBounds = BlockBoundingBoxUtility.GetBoundingBoxSelectable(blockPos.x, blockPos.y, blockPos.z, data);




                        //     blocksTmp.Add(blockBounds);
                        BlockFaces face1 = BlockFaces.PositiveY;
                        float? resultDis = ray.Intersects(blockBounds, out face1);

                        //  Debug.WriteLine(resultDis != null);
                        if (resultDis != null)
                        {
                            if (minDist > resultDis.Value)
                            {
                                result = blockPos;
                                resultFaces = face1;
                                minDist = resultDis.Value;
                            }

                        }
                    }
                }
            }

            //   Debug.WriteLine(result);
        }

}

