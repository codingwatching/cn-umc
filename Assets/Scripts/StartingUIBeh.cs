using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class StartingUIBeh : MonoBehaviour
{   
    public static RuntimePlatform platform=Application.platform;
   public Transform cameraPos;
   public Button startNewWorldButton;
   public Button continuePlayingButton;
   public Button quitButton;
   public static string gameWorldDataPath;
   public static string gameWorldPlayerDataPath;
   public static string gameWorldEntityDataPath;
   public static string gameWorldItemEntityDataPath;
   void Start(){
    cameraPos=GameObject.Find("Main Camera").GetComponent<Transform>();
    startNewWorldButton=GameObject.Find("createnewworldbutton").GetComponent<Button>();
    continuePlayingButton=GameObject.Find("continueplayingbutton").GetComponent<Button>();
    quitButton=GameObject.Find("quitbutton").GetComponent<Button>();
    startNewWorldButton.onClick.AddListener(StartNewWorldButtonOnClick);
    continuePlayingButton.onClick.AddListener(ContinuePlayingButtonOnClick);
    quitButton.onClick.AddListener(QuitButtonOnClick);
   }
   void StartNewWorldButtonOnClick(){
    CreateGameDirectory();
     SceneManager.LoadScene(1);
   }
   void CreateGameDirectory(){
     if(platform==RuntimePlatform.WindowsPlayer||platform==RuntimePlatform.WindowsEditor){
        gameWorldDataPath="C:/";
      }else{
        gameWorldDataPath=Application.persistentDataPath;
      }
         
         if (!Directory.Exists(gameWorldDataPath+"unityMinecraftData")){
                Directory.CreateDirectory(gameWorldDataPath+"unityMinecraftData");
               
            }
          if(!Directory.Exists(gameWorldDataPath+"unityMinecraftData/GameData")){
                    Directory.CreateDirectory(gameWorldDataPath+"unityMinecraftData/GameData");
                }
       
    
              FileStream fs=File.Create(gameWorldDataPath+"unityMinecraftData"+"/GameData/world.json");
        fs.Close();


    if(platform==RuntimePlatform.WindowsPlayer||platform==RuntimePlatform.WindowsEditor){
        gameWorldPlayerDataPath="C:/";
      }else{
        gameWorldPlayerDataPath=Application.persistentDataPath;
      }
         
         if (!Directory.Exists(gameWorldPlayerDataPath+"unityMinecraftData")){
                Directory.CreateDirectory(gameWorldPlayerDataPath+"unityMinecraftData");
               
            }
          if(!Directory.Exists(gameWorldPlayerDataPath+"unityMinecraftData/GameData")){
                    Directory.CreateDirectory(gameWorldPlayerDataPath+"unityMinecraftData/GameData");
                }
    
              FileStream fs1=File.Create(gameWorldPlayerDataPath+"unityMinecraftData"+"/GameData/playerdata.json");
        fs1.Close();




    if(platform==RuntimePlatform.WindowsPlayer||platform==RuntimePlatform.WindowsEditor){
        gameWorldEntityDataPath="C:/";
      }else{
        gameWorldEntityDataPath=Application.persistentDataPath;
      }
         
         if (!Directory.Exists(gameWorldEntityDataPath+"unityMinecraftData")){
                Directory.CreateDirectory(gameWorldEntityDataPath+"unityMinecraftData");
               
            }
          if(!Directory.Exists(gameWorldEntityDataPath+"unityMinecraftData/GameData")){
                    Directory.CreateDirectory(gameWorldEntityDataPath+"unityMinecraftData/GameData");
                }
       
    
              FileStream fs2=File.Create(gameWorldEntityDataPath+"unityMinecraftData"+"/GameData/worldentities.json");
        fs2.Close();



    if(platform==RuntimePlatform.WindowsPlayer||platform==RuntimePlatform.WindowsEditor){
        gameWorldItemEntityDataPath="C:/";
      }else{
        gameWorldItemEntityDataPath=Application.persistentDataPath;
      }
         
         if (!Directory.Exists(gameWorldItemEntityDataPath+"unityMinecraftData")){
                Directory.CreateDirectory(gameWorldItemEntityDataPath+"unityMinecraftData");
               
            }
          if(!Directory.Exists(gameWorldItemEntityDataPath+"unityMinecraftData/GameData")){
                    Directory.CreateDirectory(gameWorldItemEntityDataPath+"unityMinecraftData/GameData");
                }
       
     
           FileStream fs3= File.Create(gameWorldItemEntityDataPath+"unityMinecraftData"+"/GameData/worlditementities.json");
            fs3.Close();
   }
   void ContinuePlayingButtonOnClick(){
        SceneManager.LoadScene(1);
   }
   void QuitButtonOnClick(){
    Application.Quit();
   }
   void Update(){
    cameraPos.Rotate(0f,Time.deltaTime*2f,0f);
   }
}
