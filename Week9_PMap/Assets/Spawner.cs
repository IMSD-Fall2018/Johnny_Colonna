using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject boxToSpawn;

    // Use this for initialization
    void Start()
    {

    }

    float spawnTimer = 0;
    void Update()
    {
        spawnTimer += 1f;
        if (spawnTimer > 30f)
        {
            Instantiate(boxToSpawn, this.transform.position, Quaternion.identity);
            spawnTimer = 0;

        }

    }

}
