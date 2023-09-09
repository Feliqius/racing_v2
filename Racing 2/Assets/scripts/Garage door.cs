using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garagedoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 1.25f, 3.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 4)
        {
            //transform.position += new Vector3(transform.position.x, 3, transform.position.z);
        }
    }
}
