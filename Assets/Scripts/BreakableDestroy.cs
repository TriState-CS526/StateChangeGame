using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJointBreak2D(Joint2D joint)
    {
        Destroy(gameObject);
    }
}
