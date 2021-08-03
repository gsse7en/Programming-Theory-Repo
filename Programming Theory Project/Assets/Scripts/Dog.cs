using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dog : Enemy
{
    public override void Update()
    {
        Move();
        MoveForward();
    }
    void MoveForward()
    {
        if (Random.Range(0, 100) > 98)
            {
                objectRb.AddForce(Vector3.left * speed * 500);
            }
    }
}