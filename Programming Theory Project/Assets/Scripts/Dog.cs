using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dog : Enemy
{

    public override void Update()
    {
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
            return;
        }
        objectRb.AddForce(Vector3.left * speed);
        if (Random.Range(0, 100) > 98)
        {
            objectRb.AddForce(Vector3.left * speed * 500);
        }
    }
   
}