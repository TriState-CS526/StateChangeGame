using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Rigidbody2D rb;
    public float vel = 1.2f;
    public int flag = 0;
    private Vector2 v = new Vector2(1, -1);
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            flag = 1;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            flag = 0;
        }
        if (flag == 1)
        {
            rb.AddForce(Vector2.up * vel, ForceMode2D.Force);
            rb.AddForce(v * vel/2, ForceMode2D.Force);
        }
        
    }
}
