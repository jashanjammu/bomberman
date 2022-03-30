using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitOver : MonoBehaviour
{
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D target)
     {
            
            target.gameObject.SetActive(false);
             Time.timeScale=0f;
             
        
        }
       

}
