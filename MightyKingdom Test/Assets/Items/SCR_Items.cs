using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Items : MonoBehaviour
{
   
    public virtual void PickUp()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            PickUp();
            Destroy(this.gameObject);
        }

    }
}
