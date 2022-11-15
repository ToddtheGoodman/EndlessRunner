using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiController : MonoBehaviour
{

    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score:";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
