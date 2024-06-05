using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharakterMovement : MonoBehaviour
{
    private int Framecounter = 0;

    private Rigidbody2D rb;
    private float inputDirection;
   //klammer mit altgr 8/9
    [SerializeField] private float jumpforce = 5f;
    [SerializeField] private float movementspedd = 5f;
    [SerializeField] private Transform groundcheckPosition;
    [SerializeField] private float groundcheckRadius;
    [SerializeField] private LayerMask layerGroundcheck;
    [SerializeField] private int startingjumpcount;
    private int jumpcount;
    

    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Debug.Log(message: "Start!");
    }

    // Update is called once per frame
    void Update() { }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x:inputDirection * movementspedd, y: rb.velocity.y);
    }

    void OnJump()
    {
        if (Physics2D.OverlapCircle(groundcheckPosition.position,groundcheckRadius, layerGroundcheck))
        {
            jumpcount = startingjumpcount;
            
        }

        if (jumpcount >0)
        {
            rb.velocity = new Vector2(x: 0f, y: jumpforce);
            jumpcount = jumpcount - 1;

        }
    }
    void OnSneak()
    {
        Framecounter = Framecounter + 1;
        Debug.Log(message:"sneak!"+ Framecounter);
    }
    void OnSprint (InputValue inputvalue)
    {
        float isSprinting = inputvalue.Get<float>();
        Debug.Log(message: "SPRINT!" + isSprinting);
    }
    void OnMove(InputValue inputValue)
    {
        inputDirection = inputValue.Get<float>();
        Debug.Log(message:"Move!"+ inputDirection);
        if (inputDirection > 0 && !isFacingRight)
        {
           Flip();
           
           
        }else if (inputDirection <0 && isFacingRight)
        {
            Flip();
            
        }
        
    }

    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x = currentScale.x * -1;
        transform.localScale = currentScale;

        isFacingRight = !isFacingRight;
    }

    
    }

