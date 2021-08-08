using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zdun : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("IndianaEnemy"))
        {
            var rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.right * 1000, ForceMode.Force);
        }
    }
}
