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

    public int Price;

    public bool buyed;
    public bool selected;

    void Start()
    {
        SetCars(); 
        selectManager = SelectManager.GetComponent<SelectManager>();
        selectManager.coins = Convert.ToInt32(CoinsText.text);        
    }

    void Update()
    {
         ChangeCar();
        SwitchSide();
        ChangePlayerColor();
        ChangeButtons();
        CoinsText.text = Convert.ToString(selectManager.coins);
        if(transform.position == new Vector3(0, 0, 1))
        {
            BuyButtonPriceText.text = Convert.ToString(Price);
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

    public void Buy()
    {
        if (transform.position == new Vector3(0, 0, 1) && selectManager.coins >= Price)
        {
            selectManager.coins = selectManager.coins - Price;
            CoinsText.text = Convert.ToString(selectManager.coins);
            buyed = true;
        }
    }

    void ChangeButtons()
    {
        if (transform.position == new Vector3(0, 0, 1))
        {
            if(!selected && buyed)
            {
                SelectButton.SetActive(true);
            }
            else
            {
                SelectButton.SetActive(false);
            }          
            BuyButton.SetActive(!buyed);
        }
    }
}
