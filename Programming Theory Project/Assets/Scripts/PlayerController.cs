using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float zBoundTop = 15.0f;
    private float zBoundTBottom = -4.0f;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ConstrainPosition();
    }
    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
    void ConstrainPosition()
    {
        if (transform.position.x < zBoundTBottom)
        {
            transform.position = new Vector3(zBoundTBottom, transform.position.y, transform.position.z);
        }
        if (transform.position.x > zBoundTop)
        {
            transform.position = new Vector3(zBoundTop, transform.position.y, transform.position.z);
        }
    }
}
