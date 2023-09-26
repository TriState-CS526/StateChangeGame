using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float smallScale = 1.5f;
    public float enlargedScale = 3.0f;
    public float smallMass = 0.5f;
    public float enlargedMass = 500f;
    public float upwardForce = 0.5f;
    public float rightwardForce = 0.5f;

    private bool isEnlarged = true;
    public bool isFlying = false;
    public bool isFrozen = false;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isFrozen)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isEnlarged = !isEnlarged;
                if (isEnlarged)
                {
                    transform.localScale = new Vector3(enlargedScale, enlargedScale, enlargedScale);
                    rb.mass = enlargedMass;
                    isFlying = false;
                }
                else
                {
                    transform.localScale = new Vector3(smallScale, smallScale, smallScale);
                    rb.mass = smallMass;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (!isEnlarged)
                    isFlying = true;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (!isEnlarged)
                    isFlying = false;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!isFrozen)
        {
            if (isFlying)
            {
                rb.AddForce(Vector2.up * upwardForce, ForceMode2D.Force);
                rb.AddForce(Vector2.right * rightwardForce, ForceMode2D.Force);
            }
        }
            
    }
}
