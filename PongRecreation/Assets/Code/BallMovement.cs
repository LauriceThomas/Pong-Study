using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D ballRb2D;
    [SerializeField]
    private Vector3 initialVelocity;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        ballRb2D = GetComponent<Rigidbody2D>();
        ballRb2D.velocity = initialVelocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
