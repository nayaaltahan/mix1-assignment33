using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (Time.deltaTime * 2);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.collider.CompareTag(tag))
        {
            _rigidbody.isKinematic = true;
        }
 
    }
}
