using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject emptyGameObject;

    public void SpawnPrefab()
    {
        //Instantiate(prefabToSpawn, new Vector3(-42, 27, 0), Quaternion.identity);
        GameObject spawnedPrefab = Instantiate(prefabToSpawn, emptyGameObject.transform.position, Quaternion.identity);
        spawnedPrefab.transform.SetParent(emptyGameObject.transform);
    }
}
