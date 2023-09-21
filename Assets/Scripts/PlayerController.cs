using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float smallScale = 1.5f;
    public float enlargedScale = 3.0f;
    public float smallMass = 0.75f;
    public float enlargedMass = 1.5f;
    public float upwardForce = 1.0f;
    public float rightwardForce = 1.0f;

    private bool isEnlarged = true;
    public bool isFlying = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isEnlarged = !isEnlarged;

            if (isEnlarged)
            {
                transform.localScale = new Vector3(enlargedScale, enlargedScale, enlargedScale);
                rb.mass = enlargedMass;
            }
            else
            {
                transform.localScale = new Vector3(smallScale, smallScale, smallScale);
                rb.mass = smallMass;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            isFlying = !isFlying;
        }
        if (isFlying)
        {
            rb.AddForce(Vector2.up * upwardForce, ForceMode2D.Force);
            rb.AddForce(Vector2.right * rightwardForce, ForceMode2D.Force);
        }
    }
}
