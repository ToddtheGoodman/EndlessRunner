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
        //make me jump x2 higher
        PlayerController.jumpPower *= 2;
        Destroy(gameObject);
    }

}
