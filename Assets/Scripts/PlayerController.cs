using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRB;

    public float moveSpeed;
    public float jumpPower;

    public bool onGround;

    public LayerMask thisIsGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Turn the onGround bool to true
        onGround = Physics.OverlapSphere(transform.position, .75f, thisIsGround).Length > 0;
                
        //Uses the RigidBody velocity command to move the player forward endlessly
        myRB.velocity = new Vector3(moveSpeed, myRB.velocity.y, 0);

        //Uses the RB to make the player jump
        if(Input.GetButtonDown("Jump") && onGround)
        {
            myRB.velocity = new Vector3(myRB.velocity.x, jumpPower, 0);            
        }
    }
}
