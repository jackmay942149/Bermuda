using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speed;

    private float xdir;
    private float ydir;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        xdir = player.transform.position.x - transform.position.x;
        ydir = player.transform.position.y - transform.position.y;

        xdir = xdir / (Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));
        ydir = ydir / (Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));

        rb.velocity = new Vector2(xdir * speed * Time.fixedDeltaTime, ydir * speed * Time.fixedDeltaTime);
    }
}
