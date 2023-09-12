using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    public string color;

    public GameObject SelectManager;

    public GameObject SelectButton;

    SelectManager selectManager;

    public bool buyed;
    public bool selected;

    void Start()
    {
        SetCars(); 
        selectManager = SelectManager.GetComponent<SelectManager>();
    }

    void Update()
    {
         ChangeCar();
        SwitchSide();
        ChangePlayerColor();

        if(transform.position == new Vector3(0, 0, 1) && selected)
        {
            SelectButton.SetActive(false);
        }
        else
        {
            SelectButton.SetActive(true);
        }
    }

    void SetCars()
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

    void SwitchSide()
    {
        if (transform.position.x == -12)
        {
            transform.position = new Vector3(8, 0, 1);
        }

        if (transform.position.x == 12)
        {
            transform.position = new Vector3(-8, 0, 1);
        }
    }

    void ChangeCar()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(4, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(-4, 0, 0);
        }
    }

    void ChangePlayerColor()
    {
        if (selected)
        {
            selectManager.PlayerColor = color;
        }
    }

    public void Select()
    {
        if (transform.position == new Vector3(0, 0, 1))
        {
            selected = true;
        }
        else
        {
            selected = false;
        }
    }
}
