using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8.0f;
    private float turnspeed=25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //this will move the object forward
        transform.Translate(Vector3.forward*Time.deltaTime * speed * verticalInput );
        //this will rotate the object
        transform.Rotate(Vector3.up,  Time.deltaTime * turnspeed * horizontalInput);
    }
}
