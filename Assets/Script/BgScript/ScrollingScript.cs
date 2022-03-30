using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{
     public float scroll_Speed=0.3f;

    private MeshRenderer mesh_Renderer;
    // Start is called before the first frame update
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
        
    }
    void Scroll(){
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y +=scroll_Speed * Time.deltaTime;
         mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex",offset);
    }
}
