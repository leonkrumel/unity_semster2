using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private int Framecounter = 0;
    private graplinghook grapplehookscript;

    private Rigidbody2D rb;
    private float inputDirection;
   //klammer mit altgr 8/9
   //serializefiled feld in unity zum auswählen von buttons/panels usw.
   
    [SerializeField] private float jumpforce = 5f;
    [SerializeField] private float movementspedd = 5f;
    [SerializeField] private Transform groundcheckPosition;
    [SerializeField] private float groundcheckRadius;
    [SerializeField] private LayerMask layerGroundcheck;
    [SerializeField] private int startingjumpcount;
    [SerializeField] private float gravityafterapex;
    [SerializeField] private float grapplemovement;
    [SerializeField] private float lerpSpeed;
    private int jumpcount;
    private float tempdrag;
    private float isholdingsneak;
    private Vector3 tempscale;
    
    //sagt das charakter zum anfang nach rechts guckt

    private bool isFacingRight = true;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grapplehookscript = GetComponent<graplinghook>();
        tempdrag = rb.drag;
        tempscale = transform.localScale;
        
        Debug.Log(message: "Start!");
    }

    // Update is called once per frame

    void Update()
    {
        if (isholdingsneak == 0)
        {
            transform.localScale = new Vector2(transform.localScale.x, tempscale.y);
        }
    }

    private void FixedUpdate()
    {
        //checkt ob player auf dem boden ist
       MovePlayer();
       isGrounded = Physics2D.OverlapCircle(groundcheckPosition.position, groundcheckRadius, layerGroundcheck);
    }

    void OnJump()
    {
        //checkt ob charakter boden berührt bzw der groundcheck und lädt dann die sprünge wieder auf-
        //die davor festgelegte zahl in unity fest
        if (isGrounded)
        {
            jumpcount = startingjumpcount;
            
        }
        // wenn die sprünge größer als 0 sind dann kann der player springen

        if (jumpcount >0)
        {
            rb.velocity = new Vector2(x: rb.velocity.x, y: jumpforce);
            jumpcount = jumpcount - 1;

        }
    }
    void OnSneak(InputValue inputvalue)
    {
        //der scale wird halbiert wenn sneak gedrückt wird 
        isholdingsneak = inputvalue.Get<float>();
        Framecounter = Framecounter + 1;
        Debug.Log(message:"sneak!"+ Framecounter);
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2);
    }
    void OnSprint (InputValue inputvalue)
    {
        float isSprinting = inputvalue.Get<float>();
        Debug.Log(message: "SPRINT!" + isSprinting);
    }
    void OnMove(InputValue inputValue)
    {
        // wenn die input richtung über null ist und der charakter nicht nach rechts guckt dann soll flip ausgeführt-
        // werden oder wenn der input unter null ist und der charakter  nach rechts guckt
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
        // den scale um drehen damit die figur in die andere richtug zeigt
        Vector3 currentScale = transform.localScale;
        currentScale.x = currentScale.x * -1;
        transform.localScale = currentScale;

        isFacingRight = !isFacingRight;
    }

    void MovePlayer()
    {
        //geschwindigkeit vom charakter/ Rigidbody auf der x axe * eingestellte geschwindigkeit im SerializeField 
        if (grapplehookscript.isgrappeled == false)
        {
            //der charakter bescheunigt langsam
            var targetVelocity = new Vector2(inputDirection * movementspedd, rb.velocity.y);
            rb.velocity = Vector2.Lerp(rb.velocity, targetVelocity, lerpSpeed * Time.deltaTime);

            if (!isGrounded && rb.velocity.y < 0f)
            {
                //wenn nicht auf dem boden und charakter fällt dann geschwindigkeit erhöhen beim fallen
                rb.AddForce(new Vector2(0,gravityafterapex));
            }
            rb.drag = tempdrag;

        }
        else
        {
            //fügt eine kraft die den player schneller macht hinzu
            rb.AddForce(new Vector2(x:inputDirection * grapplemovement, y:0));
            rb.drag = 0;
        }
        
    }

   
    public void Addforcegrapple()
    {
        //nach loslassen der maustaste geschwindigkeit*50
        rb.AddForce(rb.velocity * 50);
    }
    

}

