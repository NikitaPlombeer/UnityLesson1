using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBlock : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void turnOnPhysics()
    {
        rigidbody.isKinematic = false;
    }
}
