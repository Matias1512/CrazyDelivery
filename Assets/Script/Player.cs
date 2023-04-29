using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private Transform tr;
    public float speed = 1f;
    public float maxSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        

        if (rb2d.velocity.magnitude < maxSpeed)
        {
            movement *= speed;
        }
        rb2d.AddForce(movement);

        if (rb2d.velocity.magnitude > 0.1f)
        {
            float angle = Mathf.Atan2(rb2d.velocity.y, rb2d.velocity.x) * Mathf.Rad2Deg;
            tr.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
