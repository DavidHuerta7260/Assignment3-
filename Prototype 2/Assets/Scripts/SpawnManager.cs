/*
David Huerta
Prototype 2
Manage what Spawns
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;


    /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            /*

            Instantiate(prefabsToSpawn[0], new Vector3(0, 0, 20), prefabsToSpawn[0].transform.rotation);

            */
            /*
            int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

            Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

            Instantiate(prefabsToSpawn[prefabIndex], new Vector3(0, 0, 20), prefabsToSpawn[prefabIndex].transform.rotation);

            SpawnRandomPrefab();

        }
    }*/

    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

    public bool gameOver = false;

    void Start()
    {
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!gameOver)
        {
            SpawnRandomPrefab();

            yield return new WaitForSeconds(1.5f);
        }
    }
}
