using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chicken : Enemy
{

    public override void Update()
    {
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
            return;
        }
        objectRb.AddForce(Vector3.left * speed / 2);
        objectRb.AddForce(Vector3.forward * speed * Random.Range(-1.0f, 1.0f));
    }
   
}