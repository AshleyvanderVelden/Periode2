using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemSpawner : MonoBehaviour {
    public Transform spawnLocations;
    public GameObject whatToSpawnPrefab;
    public GameObject whatToSpawnClone;
    public float count;
    public float wait;
    void Start()
    {
        count = wait - 5;
    }
    void SpawnObject()
    {
        whatToSpawnClone = Instantiate(whatToSpawnPrefab, transform.position, Quaternion.identity);
    }
    void Update()
    {
        count = count + 1;
        if (count == wait)
        {
            SpawnObject();
            count = 0;
        }
    }
}
