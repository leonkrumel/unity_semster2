using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class victoryarea : MonoBehaviour
{
    private UILevelManager uiLevelManger;
    // Start is called before the first frame update
    void Start()
    {
        uiLevelManger = FindObjectOfType<UILevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("goal"))
        {
         Debug.Log(message:"win");   
         uiLevelManger.OnGameWin();
        }
        else if (other.CompareTag("dead"))
        {
            Debug.Log(message: "dead");
            uiLevelManger.OnGameLose();
        }
    }

    
    
}
