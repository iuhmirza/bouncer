using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 10;
    Vector3 velocity;
    Rigidbody myRigidbody;
    public Transform cameraTransform;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        cameraTransform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        myRigidbody.position += velocity * Time.fixedDeltaTime;
    }
}
