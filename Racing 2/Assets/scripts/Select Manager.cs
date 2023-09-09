using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public GameObject Camera;

    public GameObject Door;

    bool go = false;

    // Start is called before the first frame update
    void Start()    
    {
        Camera.transform.position = new Vector3(0, 2, 7);
        Camera.transform.eulerAngles = new Vector3(13, 180, 0);

        Door.transform.position = new Vector3(0, 1.25f, 3.7f);

    }

    // Update is called once per frame
    void Update()
    {

        if(Door.transform.position.y < 4)
        {
            Door.transform.position += new Vector3(0, 0.5f, 0) * Time.deltaTime;
        }

        if(Door.transform.position.y >= 4)
        {
            go = true;
        }

        if(go == true && Camera.transform.position.z > 3)
        {
            Camera.transform.position += new Vector3(0, 0, -2) * Time.deltaTime;
        }

        if(Camera.transform.eulerAngles.x < 25 && go)
        {
            Camera.transform.eulerAngles += new Vector3(5.6f, 0, 0) * Time.deltaTime;
        }
    }
}
