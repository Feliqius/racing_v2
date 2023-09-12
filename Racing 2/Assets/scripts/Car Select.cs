using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CarSelect : MonoBehaviour
{
    public string color;

    public GameObject SelectManager;

    public GameObject SelectButton;
    public GameObject BuyButton;
    public Text BuyButtonPriceText;

    public Text CoinsText;

    SelectManager selectManager;

    int Coins;

    public int Price;

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
        ChangeButtons();;

        
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

    public void Buy()
    {
        if (transform.position == new Vector3(0, 0, 1) && Convert.ToInt32(CoinsText.text) > Price)
        {
            buyed = true;
            CoinsText.text = Convert.ToString(Convert.ToInt32(CoinsText) - 100);
        }
    }

    void ChangeButtons()
    {
        if (transform.position == new Vector3(0, 0, 1) && selected)
        {
            SelectButton.SetActive(false);
        }
        else
        {
            SelectButton.SetActive(true);
        }

        if (buyed == false)
        {
            SelectButton.SetActive(false);
        }

        if (transform.position == new Vector3(0, 0, 1) && !buyed)
        {
            SelectButton.SetActive(false);
            BuyButton.SetActive(true);
        }

        if (transform.position == new Vector3(0, 0, 1) && buyed)
        {
            SelectButton.SetActive(true);
            BuyButton.SetActive(false);
        }
    }
}
