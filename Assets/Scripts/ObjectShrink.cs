using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShrink : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 originalScale;
    private bool isEnlarged = false;
    
    void Start()
    {
     originalScale = transform.localScale;   
    }

    // Update is called once per frame
    
    private void Update(){
        // Check for a specific key press (e.g., the spacebar)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isEnlarged)
            {
                // Shrink the object back to its original size
                transform.localScale = originalScale;
                gameObject.GetComponent<Rigidbody2D>().mass = 1.5f;
            }
            else
            {
                // Enlarge the object
                transform.localScale /= 2f; // You can adjust the scaling factor as needed
                gameObject.GetComponent<Rigidbody2D>().mass = 0.5f;
            }

            // Toggle the state
            isEnlarged = !isEnlarged;
        }
    }
}
