using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class victoryarea : MonoBehaviour
{
   //greift auf script UIlevelmanger zu 
    private UILevelManager uiLevelManger;
    // Start is called before the first frame update
    void Start()
    {
        uiLevelManger = FindObjectOfType<UILevelManager>();
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
       // wenn charakter objekt mit tag "goal" berührt dann msg: win und führe ongame win aus uilevelmanager aus
        if (other.CompareTag("goal"))
        {
         Debug.Log(message:"win");   
         uiLevelManger.OnGameWin();
        }
        // wenn charakter objekt mit tag "dead" berührt dann msg: dead und führe ongamelose aus uilevelmanager aus
        else if (other.CompareTag("dead"))
        {
            Debug.Log(message: "dead");
            uiLevelManger.OnGameLose();
        }
    }

    
    
}
