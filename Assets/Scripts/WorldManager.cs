using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public Transform playerPos;
    void Awake(){
        playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            if(!EntityBeh.isEntitiesLoad){
            EntityBeh.LoadEntities();
        }
                if(EntityBeh.isEntitiesReadFromDisk==false){
            EntityBeh.ReadEntityJson();
        }
            EntityBeh.SpawnEntityFromFile();
            ItemEntityBeh.ReadItemEntityJson();
            ItemEntityBeh.playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            StartCoroutine(ItemEntityBeh.SpawnItemEntityFromFile());
            
    }
    void FixedUpdate(){
        if(Random.Range(0f,100f)>99.7f&&EntityBeh.worldEntities.Count<70){
            Vector2 randomSpawnPos=new Vector2(Random.Range(playerPos.position.x-40f,playerPos.position.x+40f),Random.Range(playerPos.position.z-40f,playerPos.position.z+40f));
          EntityBeh.SpawnNewEntity(randomSpawnPos.x,Chunk.GetChunkLandingPoint(randomSpawnPos.x,randomSpawnPos.y),randomSpawnPos.y,(int)Random.Range(0f,1.99f));  
        }
    }
    void Update(){
 


        if(Input.GetKeyDown(KeyCode.H)){
     //   EntityBeh.SpawnNewEntity(0,100,0,0);
       // EntityBeh.SpawnNewEntity(0,100,0,1);
       StartCoroutine(ItemEntityBeh.SpawnNewItem(0,70,0,1,Vector3.up));
        }
                if(Input.GetKeyDown(KeyCode.L)){

                        StartCoroutine(ItemEntityBeh.SpawnNewItem(0,70,0,101,Vector3.up));

                }
     //   EntityBeh.SpawnNewEntity(0,100,0,0);
       // EntityBeh.SpawnNewEntity(0,100,0,1);
     //  StartCoroutine(ItemEntityBeh.SpawnNewItem(0,70,0,1,Vector3.up));
    // foreach(ItemEntityBeh i in ItemEntityBeh.worldItemEntities){
     //   i.AddForceInvoke(Vector3.up*10f);
   //  }
     //   }
    }
}
