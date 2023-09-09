using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    public string color;

    public string CurrentCar;

    Vector3 Garage;
    Vector3 Outdoor;

    // Start is called before the first frame update
    void Start()
    {
        Garage = new Vector3(0, 0, 1);
        Outdoor = new Vector3(10, 10, 10);
        goOut();
        CurrentCar = "red";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            CarChange();
        }
    }

    void CarChange()
    {
        if (Input.GetAxis("Horizontal") == 1)
        {
            switch (CurrentCar)
            {
                case "red":
                    Change("yellow");
                    break;

                case "yellow":
                    Change("blue");
                    break;
                
                case "blue":
                    Change("white");
                    break;

                case "white":
                    Change("purple");
                    break;

                case "purple":
                    Change("red");
                    break;
            }

        }
        else
        {
            switch (CurrentCar)
            {
                case "red":
                    Change("purple");
                    break;

                case "yellow":
                    Change("red");
                    break;

                case "blue":
                    Change("yellow");
                    break;

                case "white":
                    Change("blue");
                    break;

                case "purple":
                    Change("white");
                    break;
            }
        }
    }

    void goToGarage()
    {
        transform.position = Garage;
        Debug.Log("1");
    }

    void goOut()
    {
        transform.position = Outdoor;
    }

    void Change(string nextCoulour)
    {
        if (color == nextCoulour)
        {
            goToGarage();
        }
        else
        {
            goOut();
        }
    }
}
