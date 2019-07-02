using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI tmp = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space"))
        {
            tmp.SetText("Hello World, My name is Justin Snell!");
            Debug.Log("space key pressed");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
