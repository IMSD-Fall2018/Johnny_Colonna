using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallToSpawn : MonoBehaviour {

    public GameObject ballToSpawn;
    Vector3 maxDistance; 

    // Use this for initialization
    void Start()
    {

    }

    float spawnTimer = 0;
    void Update()
    {
        spawnTimer += 1f;
        if (spawnTimer > 15f)
        {
            Instantiate(ballToSpawn,this.transform.position, Quaternion.identity);
            spawnTimer = 0;

        }

    }
}
