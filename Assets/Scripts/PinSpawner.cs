using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSpawner : MonoBehaviour
{
    public GameObject pin;
    public Text scoreText;
    public static int score;

    public static bool canPin = true;
    
    // Update is called once per frame
    void Update()
    {
        if (canPin && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            GameObject temp =  Instantiate(pin, transform.position, transform.rotation);
            temp.GetComponent<PinBehaviour>().scoreText = scoreText;
            
        }
    }
}
