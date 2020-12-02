using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SaberScript : MonoBehaviour
{
    private Vector3 previousPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit) 
                                                                           )
        {
           if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130 && hit.collider.CompareTag(tag))
           {
                Destroy(hit.transform.gameObject);
           }
        }
        previousPos = transform.position;
    }

    
}
