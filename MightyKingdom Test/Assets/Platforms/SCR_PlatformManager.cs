using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlatformManager : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject lastPlatform;
    [SerializeField] private float verticalOffSet;
    [SerializeField] private GameObject scoreMultiplier;
    private void Spawn()
    {
        Vector3 position = new Vector3(transform.position.x + lastPlatform.transform.lossyScale.x/8, Random.Range(0,verticalOffSet),0);
        lastPlatform = Instantiate(platforms[Random.Range(0, platforms.Length)], position, spawnPoint.transform.rotation);
        if (Random.Range(0, 100) < 30) Instantiate(scoreMultiplier, new Vector3(position.x, position.y + 1, position.z), spawnPoint.transform.rotation);
    } 

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Platform"))
        {
            Spawn();
        }

    }
}
