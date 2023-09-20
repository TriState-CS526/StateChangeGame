using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;
    public Vector3 offset;
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
