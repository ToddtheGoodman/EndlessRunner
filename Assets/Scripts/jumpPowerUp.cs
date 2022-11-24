using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(jumpCooldown());

        //turn off the mesh renderer       
               
    }

    IEnumerator jumpCooldown()
    {
        print("Cooldown test");

        //double my jump power
        PlayerController.jumpPower *= 2;

        //wait 2 seconds
        yield return new WaitForSeconds(2);

        //half my jump power
        PlayerController.jumpPower /= 2;

        Destroy(gameObject);
    }
    
}
