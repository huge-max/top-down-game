using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1 : MonoBehaviour
{
    public float speed;
    public float horizontalRange;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x > 5f) 
        {
            //change direction to left
            rb.velocity = new Vector2(-speed, 0);
        }

        if (transform.position.x < -12f)
        {
            //change direction to right
            rb.velocity = new Vector2(speed, 0);
        }

    }
}