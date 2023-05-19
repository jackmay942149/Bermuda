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
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xdir = player.transform.position.x - transform.position.x;
        ydir = player.transform.position.y - transform.position.y;

        xdir = xdir/(Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));
        ydir = ydir/(Mathf.Sqrt(Mathf.Pow(xdir, 2) + Mathf.Pow(ydir, 2)));

        velocity = speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + xdir * velocity, transform.position.y + ydir * velocity);
    }
}
