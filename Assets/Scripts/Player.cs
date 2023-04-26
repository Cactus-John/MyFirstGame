using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Player : MonoBehaviour
{
    bool canJump;
    bool touchGround;

    private Rigidbody rigidBodyComponent;
    private float horizontal;

    public float speed = 500f;

    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        canJump = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && touchGround == true)
        {
            canJump = true;
        }

        if (Input.GetKey(KeyCode.W) && canJump == true)
        {
            rigidBodyComponent.AddForce(transform.up * 24f);
        }

        if (Input.GetKey(KeyCode.S) && canJump == false)
        {
            rigidBodyComponent.AddForce(-transform.up * 0.675f);
        }

        if (Input.GetKey(KeyCode.D) && canJump == false)
        {
            rigidBodyComponent.AddForce(transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && canJump == false)
        {
            rigidBodyComponent.AddForce(transform.forward * speed * Time.deltaTime); ;
        }

        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (canJump)
        {
            rigidBodyComponent.AddForce(6 * Vector3.up, ForceMode.VelocityChange);
            canJump = false;
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