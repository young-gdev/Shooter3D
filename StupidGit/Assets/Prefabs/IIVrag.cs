using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IIVrag : MonoBehaviour
{
    public float speed;

    Transform target;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Hero")
        {
           transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        speed = 0;
    }
}
