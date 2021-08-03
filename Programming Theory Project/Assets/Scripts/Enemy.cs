using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed;
    public float xBound;
    protected Rigidbody objectRb;

    private void Start() {
        objectRb = GetComponent<Rigidbody>();
    }

    public virtual void Update()
    {
       Move();
    }
    protected void Move()
    {
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
            return;
        }
        objectRb.AddForce(Vector3.left * speed);
    }
}