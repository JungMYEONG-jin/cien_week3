using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActTest : MonoBehaviour
{


    Rigidbody rb;
    public float y_pow=0f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up*y_pow,ForceMode.Impulse );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
