using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene: MonoBehaviour
{
    public NextScene objem;
  

    public void GoNextLevel(){    
    SceneManager.LoadSceneAsync("OyunSahnesi");
    Time.timeScale=1f;
    Zaman.our_time1=40;
   
   if(SceneManager.GetActiveScene().buildIndex == 1  ){ 
    BackGroundMusic.instance.GetComponent<AudioSource>().Play();
   }
    }
}
