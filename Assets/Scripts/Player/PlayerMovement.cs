using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Variables to hold movement direction
    private float xdir = 0f;
    private float ydir = 0f;
    private float diagLimiter = 0.7f;

    // Player Rigidbody
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Get the player inputs
        xdir = Input.GetAxisRaw("Horizontal");
        ydir = Input.GetAxisRaw("Vertical");

        if (xdir !=0 && ydir !=0)
        {
            xdir *= diagLimiter;
            ydir *= diagLimiter;
        }

        rb.velocity = new Vector2(xdir * speed * Time.fixedDeltaTime, ydir * speed * Time.fixedDeltaTime);
    }
}
