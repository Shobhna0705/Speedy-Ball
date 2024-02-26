using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rd;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;
    
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rd.enabled = false;
        rb.useGravity = false;
    }

    
    void Update()
    {
        if(Time.time > timeToWait)
        {
            rd.enabled = true;
            rb.useGravity = true;
        }
        
    }
}
