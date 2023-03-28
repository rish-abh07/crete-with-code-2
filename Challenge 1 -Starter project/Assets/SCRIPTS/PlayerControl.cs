using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   public float speed = 2.0f ;
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed = 10.0f;
    public float rotate_up_down;
    public float rotate_left_right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //to move plane forward
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        rotate_left_right = Time.deltaTime * turnspeed * horizontalInput ;
        rotate_up_down = Time.deltaTime * turnspeed * verticalInput ;
        transform.Rotate(rotate_up_down, 0.00f, 0.00f, Space.Self) ;
        transform.Rotate(0.00f, 0.00f, rotate_left_right, Space.Self) ;
    }
}
