using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float layer = 5.0f;
    private Rigidbody2D myBody;
    public float moveSpeed =2f;
    public float xMin=-2.62f;
    public float xMax=2.62f;
    public float player_YBond = -3.7184f;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

     
    // Update is called once per frame
  
    void FixedUpdate()
    {
        move();
        
        
    }
    
     
    void move()
    {    float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;
        
         
        
         if(h > 0)
        {
         // move right side block
         //temp.x = temp.x + speed * Time.deltaTime;
         temp.x += moveSpeed  * Time.deltaTime;
         
        }
         else if(h < 0)
        {
         // move left side block
          temp.x -= moveSpeed  * Time.deltaTime;
          
        }
          if(temp.x < xMin )
          {
            temp.x = xMin;
           }
        if(temp.x > xMax )
        {
            temp.x = xMax;
        }
        //  if (temp.y ==  player_YBond)
        //  {
        //      gameObject.SetActive(false);
        //      Time.timeScale=0;
        //  }
          
         transform.position = temp ;
         
          
        
        }
         void OnTriggerEnter2D(Collider2D target)
         {
            Time.timeScale =0f;
                 
         }
        
    
    

    //     public void platformMove(float x){
    //             myBody.velocity = new Vector2(x,myBody.velocity.y);
        
    // }
}
