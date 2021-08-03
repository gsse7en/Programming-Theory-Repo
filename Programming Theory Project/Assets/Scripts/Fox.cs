using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fox : Enemy
{
    public override void Update()
    {
       Move();
       MoveTowardsPlayer();
    }
    void MoveTowardsPlayer()
    {
        GameObject player = GameObject.Find("Player");
        if (Random.Range(0, 100) > 97)
        {
            objectRb.AddForce((player.transform.position - transform.position) * speed * 100);
        }
    }
}