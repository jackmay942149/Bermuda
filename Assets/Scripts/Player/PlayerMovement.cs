using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Variables to hold movement direction
    private float xdir = 0;
    private float ydir = 0;
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            Move();
        }
    }

    private void Move()
    {
        // Get the player inputs
        xdir = Input.GetAxisRaw("Horizontal");
        ydir = Input.GetAxisRaw("Vertical");

        xdir = xdir/(Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));
        ydir = ydir/(Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));

        // Find velocity
        velocity = speed * Time.deltaTime;
        Debug.Log(velocity);

        // Apply player movement
        transform.position = new Vector2(transform.position.x + xdir * velocity, transform.position.y + ydir * velocity);
    }
}
