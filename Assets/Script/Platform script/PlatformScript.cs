using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
     public float Speed=2f;
     public float bound_y =6f;

     public bool moving_platform_left,moving_platform_right,is_breakable,is_spike,is_platform;
     private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
       if(is_breakable)
       {
           anim =GetComponent<Animator>();
       }
     
    }

    // Update is called once per frame
    void Update()
    {
         upward();
         
    }
    void upward(){
        Vector2 temp = transform.position;
        temp.y += Speed * Time.deltaTime;
        transform.position = temp;
        if(temp.y >= bound_y ){
            gameObject.SetActive(false);

       }
       
      
    }

    // void BreakableDeactivate(){
    //     Invoke("DeactiveGameObject",0.3f);
    // }
    // void DeactiveGameObject(){
    //     gameObject.SetActive(false);
    // }

    // void OnCollisionEnter2D(Collision2D target)
    // {
    //     if(target.gameObject.tag == "player"){
    //        if(is_breakable){
    //          anim.Play("Break");
    //        }
    //        if(is_platform){
               
    //        }
       
           
       // }
 //  }
     
}
