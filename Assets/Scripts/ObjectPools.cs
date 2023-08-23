using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
public class MyChunkObjectPool{
 
    public GameObject Object;
 
    public Queue<GameObject> objectPool = new Queue<GameObject>();
   
 //   public int defaultCount = 16;
 
    public int maxCount = 25;
 
 /*   public void Init()
    {
        GameObject obj;
        for (int i = 0; i < defaultCount; i++)
        {
            obj = Instantiate(Object, this.transform);
            objectPool.Enqueue(obj);
            obj.SetActive(false);
        }
    }*/
    // 从池子中取出物体
    public GameObject Get(Vector2Int pos)
    {
        GameObject tmp;
    
        if (objectPool.Count > 0)
        {
            // 将对象出队
            tmp = objectPool.Dequeue();
            tmp.transform.position=new Vector3(pos.x,0,pos.y);
            tmp.SetActive(true);
        }
  
        else
        {
            return GameObject.Instantiate(Object, new Vector3(pos.x,0,pos.y),Quaternion.identity);
            
        }
        return tmp;
    }
    // 将物体回收进池子
    public void Remove(GameObject obj)
    {
        // 池子中的物体数目不超过最大容量
        if (objectPool.Count <= maxCount)
        {
        	// 该对象没有在队列中
            if (!objectPool.Contains(obj))
            {
                // 将对象入队
                objectPool.Enqueue(obj);
                obj.SetActive(false);
            }
        }
        // 超过最大容量就销毁
        else
        {
            GameObject.Destroy(obj);
        }
    }

}

public class ObjectPools : MonoBehaviour
{
        public static GameObject chunkPrefab;
        public static GameObject particlePrefab;
    public static ObjectPool<GameObject> particleEffectPool;
    public static MyChunkObjectPool chunkPool=new MyChunkObjectPool();

    public void Awake(){
        particlePrefab=Resources.Load<GameObject>("Prefabs/blockbreakingparticle");
        particleEffectPool=new ObjectPool<GameObject>(CreateEffect, GetEffect, ReleaseEffect, DestroyEffect, true, 10, 300);
        chunkPrefab=Resources.Load<GameObject>("Prefabs/chunk");
        chunkPool.Object=chunkPrefab;
        chunkPool.maxCount=100;
    }
  
    public GameObject CreateEffect()
    {
        GameObject gameObject = Instantiate(particlePrefab, transform.position, Quaternion.identity);
 
        return gameObject;
    }
    
    void GetEffect(GameObject gameObject)
    {
 
        gameObject.SetActive(true);
   
    }
    void ReleaseEffect(GameObject gameObject)
    {
        gameObject.SetActive(false);
  
    }
    void DestroyEffect(GameObject gameObject)
    {
    
        Destroy(gameObject);
    }

}