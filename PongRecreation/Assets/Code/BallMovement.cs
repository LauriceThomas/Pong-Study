using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D ballRb2D;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        ballRb2D = GetComponent<Rigidbody2D>();
        ballRb2D.AddForce(new Vector2(-8, 0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
