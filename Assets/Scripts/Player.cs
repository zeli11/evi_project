using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 7, 0);
        }

        if (Input.GetKey("escape"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 7, 0);
        }
    }
}
