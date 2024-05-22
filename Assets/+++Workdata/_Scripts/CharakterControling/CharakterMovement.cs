using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharakterMovement : MonoBehaviour
{
    private int Framecounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Start!");
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    void OnJump()
    {
        Framecounter = Framecounter + 1;
        Debug.Log(message:"Jump!"+ Framecounter);
    }
    void OnSneak()
    {
        Framecounter = Framecounter + 1;
        Debug.Log(message:"sneak!"+ Framecounter);
    }
    void OnSprint()
    {
        Framecounter = Framecounter + 1;
        Debug.Log(message:"SPRINT!"+ Framecounter);
    }
    void OnMove()
    {
        Framecounter = Framecounter + 1;
        Debug.Log(message:"Move!"+ Framecounter);
    }

}
