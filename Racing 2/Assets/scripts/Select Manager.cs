using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public GameObject Camera;

    public GameObject Door;

    public GameObject Canvas;

    public string PlayerColor;

    public int coins;

    public int PlayerSpeed;

    bool go = false;

    // Start is called before the first frame update
    void Start()    
    {        
        SetObjectives();
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
        CameraToGarage();       
    }

    void OpenDoor()
    {
        if (Door.transform.position.y < 4)
        {
            Door.transform.position += new Vector3(0, 0.5f, 0) * Time.deltaTime;
        }

        if (Door.transform.position.y >= 4)
        {
            go = true;
        }
    }

    void CameraToGarage()
    {
        if (go == true && Camera.transform.position.z > 3.5)
        {
            Camera.transform.position += new Vector3(0, 0, -2) * Time.deltaTime;
        }

        if (Camera.transform.eulerAngles.x < 25 && go)
        {
            Camera.transform.eulerAngles += new Vector3(5.6f, 0, 0) * Time.deltaTime;
            Canvas.SetActive(true);
        }
    }

    void SetObjectives()
    {
        Canvas.SetActive(false);

        Camera.transform.position = new Vector3(0, 2, 6);
        Camera.transform.eulerAngles = new Vector3(13, 180, 0);

        Door.transform.position = new Vector3(0, 1.25f, 3.7f);
    }
}
