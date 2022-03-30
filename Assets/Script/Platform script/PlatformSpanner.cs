using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpanner : MonoBehaviour
{
    public GameObject platformPrefab;
     public GameObject spikePlatformPrefab;
     public GameObject []movingPlatform;
     public GameObject breakablePlatform;
     public float platform_Spawn_Timer ;
     public float current_Platform_Spawn_Timer;

     public int platform_Spawn_Count;
     
     public float min_X = -2 , max_X = 2;


    // Start is called before the first frame update
    void Start()
    {
     current_Platform_Spawn_Timer = platform_Spawn_Timer;   
    }

    // Update is called once per frame
    void Update(){
      SpawnPlatforms();
        
    }
    void SpawnPlatforms(){
     current_Platform_Spawn_Timer += Time.deltaTime;

     if(current_Platform_Spawn_Timer >= platform_Spawn_Timer){

       platform_Spawn_Count++;
       Vector2 temp = transform.position;
       temp.x = Random.Range(min_X, max_X);

       GameObject newPlatform = null;

       if(platform_Spawn_Count < 2 ){

           newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
       
       }else if(platform_Spawn_Count == 2){
           
           if(Random.Range(0,2) > 0){
               
              newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
           }else{
               
               newPlatform = Instantiate(
               movingPlatform[Random.Range(0,movingPlatform.Length)],temp,Quaternion.identity);
           }
       
       }else if(platform_Spawn_Count == 3){
            
            if(Random.Range(0,2) > 0){

                 newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
            }else{
                newPlatform = Instantiate(spikePlatformPrefab, temp, Quaternion.identity);
            }
       }else if(platform_Spawn_Count == 4){
            
           if(Random.Range(0,2) > 0){

               newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
      }else{
             newPlatform = Instantiate(breakablePlatform, temp, Quaternion.identity);
            }
          platform_Spawn_Count = 0;
      }
           current_Platform_Spawn_Timer = 0f;
     }//spawn platform

    
    }
} // class
