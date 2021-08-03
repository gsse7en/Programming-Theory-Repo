using UnityEngine;
public class Chicken : Enemy
{
    public override void Update()
    {
        Move();
        MoveSideToSide();
    }
    void MoveSideToSide()
    {
        objectRb.AddForce(Vector3.forward * speed * Random.Range(-1.0f, 1.0f));
    }
   
}