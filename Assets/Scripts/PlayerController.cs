using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRB;

    public float moveSpeed;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new Vector3(moveSpeed, myRB.velocity.y, 0);

        if(Input.GetButtonDown("Jump"))
        {
            myRB.velocity = new Vector3(myRB.velocity.x, jumpPower, 0);
        }
    }
}
