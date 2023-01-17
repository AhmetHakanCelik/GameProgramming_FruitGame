using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    AudioSource ses;
    public static Hareket objem;
    void Start()
    {   
        if(objem==null){
            objem =this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(objem!=this.gameObject){
            Destroy(this.gameObject);  
        }     
        ses=GetComponent<AudioSource>();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ){
            ses.Play();
        }
    }
   
   void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal")<0)
       {
           transform.position -= new Vector3(1f, 0.0f, 0.0f); 
           
       }
        else if (Input.GetAxis("Horizontal")>0)
       { 
           transform.position += new Vector3(1f, 0.0f, 0.0f); 
       }
    }
   
}
