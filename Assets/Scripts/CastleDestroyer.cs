using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Domino"))
        {
            foreach (CastleBlock castleBlock in FindObjectsOfType<CastleBlock>())
            {
                castleBlock.turnOnPhysics();
            }
        }
    }
}
