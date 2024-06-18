using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graplinghook : MonoBehaviour
{
    [SerializeField] private float grapplelenggh;

    [SerializeField] private LayerMask grapplelayer;
    [SerializeField] private LineRenderer rope;

    private Vector3 grapplepoint;
    public bool isgrappeled;

    private DistanceJoint2D joint;
    // Start is called before the first frame update
    void Start()
    {
        joint = gameObject.GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        rope.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //neues hinzufügen inputsystem!!
        
        if (Input.GetMouseButtonDown(0))
        {
            // an die position wo hin geklickt wird, wird der grappler geschossen aber nur wenn sich das objeckt auf dem grapple layer befindet
            RaycastHit2D hit = Physics2D.Raycast(
                origin: Camera.main.ScreenToWorldPoint(Input.mousePosition),
                direction: Vector2.zero,
                distance: Mathf.Infinity,
                layerMask: grapplelayer
                );

            if (hit.collider !=null)
            {
                // der player wird an das objeckt rangezogen 
                grapplepoint = hit.point;
                grapplepoint.z = 0;
                joint.connectedAnchor = grapplepoint;
                joint.enabled = true;
                joint.distance = grapplelenggh;
                rope.SetPosition(0, grapplepoint);
                rope.SetPosition(1, transform.position);
                rope.enabled = true;
                isgrappeled = true;

            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            // das seil ausgeschalten und der player bekommt einen boost in die richtung in die er sich bewegt 
            joint.enabled = false;
            rope.enabled = false;
            isgrappeled = false;
            GetComponent<CharacterMovement>().Addforcegrapple();
        }

        if (rope.enabled == true)
        {
            rope.SetPosition(1, transform.position);
        }
    }
}
