using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed;// = 50.0f;
    public Rigidbody objectRb;
    public float xBound;//   = -7.0f;
    private void Start() {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
            return;
        }
        objectRb.AddForce(Vector3.left * speed);
    }
}