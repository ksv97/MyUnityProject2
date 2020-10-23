using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float rotateAmount;

    float rotation;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 vector3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (vector3.x < 0)
            {
                rotation = rotateAmount;
            }
            else rotation = -rotateAmount;

            transform.Rotate(0, 0, rotation);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;   
    }
}
