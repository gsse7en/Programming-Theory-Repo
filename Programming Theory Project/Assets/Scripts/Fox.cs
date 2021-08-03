using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fox : Enemy
{

    public override void Update()
    {
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
            return;
        }
        objectRb.AddForce(Vector3.left * speed);
        GameObject player = GameObject.Find("Player");
        if (Random.Range(0, 100) > 97)
        {
            objectRb.AddForce((player.transform.position - transform.position) * speed * 100);
        }
    }
   
}