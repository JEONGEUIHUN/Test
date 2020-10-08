using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 0.5f;
    private int rotSpeed = 300;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //float deltaMove = speed * Time.deltaTime;
        float deltaRot = rotSpeed * Time.smoothDeltaTime;

        //float keyForward = Input.GetAxis("Vertical");
        float keySide = Input.GetAxis("Horizontal");

        //transform.Translate(Vector3.forward * deltaMove * keyForward);
        transform.Rotate(Vector3.up * deltaRot * keySide);
        

        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * deltaMove);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMove);
        }
        */
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * deltaRot);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -deltaRot);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
