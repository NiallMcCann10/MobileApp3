using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject leftBat;
    public GameObject rightBat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if(Input.GetKey (KeyCode.W)) {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 7f, 0f);
        }

        else if(Input.GetKey (KeyCode.S)) {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -7f, 0f);
        }
        else if(Input.GetKey (KeyCode.A)) {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(-7f, 0f, 0f);
        }
        else if(Input.GetKey (KeyCode.D)) {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(7f, 0f, 0f);
        }


        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if(Input.GetKey (KeyCode.UpArrow)) {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 7f, 0f);
        }

        else if(Input.GetKey (KeyCode.DownArrow)) {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -7f, 0f);
        }

        else if(Input.GetKey (KeyCode.LeftArrow)) {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(-7f, 0f, 0f);
        }

        else if(Input.GetKey (KeyCode.RightArrow)) {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(7f, -7f, 0f);
        }
    }
}
