using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeComponent : MonoBehaviour
{
    private bool used = false;
    private PlayerController playerController;
    private Rigidbody2D rb;
    // Start is called before the first frame update
     void OnCollisionEnter2D(Collision2D collision)
     {
        if (!used)
        {
            used = true;
            GameObject other = collision.gameObject;
            rb = other.GetComponent<Rigidbody2D>();
            playerController = other.GetComponent<PlayerController>();
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            playerController.isFrozen = true;
            Invoke(nameof(RemoveFrozen), 2.0f);
        }
     }

    void RemoveFrozen()
    { 
        playerController.isFrozen = false;
        rb.constraints = RigidbodyConstraints2D.None;
    }

}
