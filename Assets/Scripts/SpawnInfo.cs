using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInfo : MonoBehaviour
{
    public static Transform destroyLocation;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spawn"))
        {
            //destroyLocation = this.transform.position;
            destroyLocation = collision.gameObject.transform;
        }
    }
}
