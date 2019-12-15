using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PLaformDestroyer : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
