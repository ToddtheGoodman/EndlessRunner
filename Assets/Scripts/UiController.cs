using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiController : MonoBehaviour
{

    public TextMeshProUGUI score;
    public static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        //score.text = "Score:"; //add to this every time I pickup
    }

    // Update is called once per frame
    void Update()
    {
        // add scoreValue variable to my score
        score.text = "Score:" + scoreValue;
    }
}
