using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Obsticle : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
            Destroy(collider.gameObject);
    }
}
