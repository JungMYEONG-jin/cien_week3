using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌입니다" + other.gameObject.name);
        
        
        

    }


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("충돌 발생! " + col.gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("탈출입니다! " + other.gameObject.tag);    
    }


}
