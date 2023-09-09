using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    public string color;

    void Start()
    {
        switch (color)
        {
            case "red":
                transform.position = new Vector3(0, 0, 1);
                break;

            case "yellow":
                transform.position = new Vector3(4, 0, 1);
                break;

            case "white":
                transform.position = new Vector3(-4, 0, 1);
                break;

            case "purple":
                transform.position = new Vector3(8, 0, 1);
                break;

            case "blue":
                transform.position = new Vector3(-8, 0, 1);
                break;
        }
                   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(4, 0 ,0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(-4, 0, 0);
        }

        if(transform.position.x == -12)
        {
            transform.position = new Vector3(8, 0, 1);
        }

        if (transform.position.x == 12)
        {
            transform.position = new Vector3(-8, 0, 1);
        }
    }
}
