using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    bool jump;
    bool touchGround;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && touchGround == true) 
        { 
            jump = true;
        }

        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if(jump) 
        {
            rigidBodyComponent.AddForce(6 * Vector3.up, ForceMode.VelocityChange);
            jump = false;
            touchGround = false;
        }

        rigidBodyComponent.velocity = new Vector3(horizontal, rigidBodyComponent.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        touchGround = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
