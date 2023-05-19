using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    // Initialise a variable to hold raycast info
    private bool inside = false;
    private SpriteRenderer sr;
    private float alpha = 1.0f;

    [SerializeField]
    private float visiblityChangeRate;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (inside && alpha > 0)
        {
            alpha -= Time.fixedDeltaTime * visiblityChangeRate;
        }
        else if (!inside && alpha < 1)
        {
            alpha += Time.fixedDeltaTime * visiblityChangeRate;
        }

        sr.color = new Color(sr.color.r, sr.color.b, sr.color.g, alpha);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inside = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inside = false;
    }
}
