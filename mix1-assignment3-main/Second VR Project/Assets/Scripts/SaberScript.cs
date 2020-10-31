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
        if(Physics.Raycast(transform.position, transform.forward, out hit) //&& (hit.transform.gameObject == transform.gameObject)
                                                                           )
        {
           if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130 && hit.collider.CompareTag(tag))
           {
                Destroy(hit.transform.gameObject);
                Debug.Log("111");
           }
        }
        previousPos = transform.position;
    }

    //  private void OnCollisionEnter(Collision col)
    // {
    //     Debug.Log("323");
    //     if ( col.collider.CompareTag(tag) )
    //     {
    //         Destroy(col.transform.gameObject);
    //         Debug.Log("111");
    //     }
    // }
}
