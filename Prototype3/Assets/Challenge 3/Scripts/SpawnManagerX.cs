﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        InvokeRepeating("objectPrefabs", spawnDelay, spawnInterval);
    }

    // Spawn obstacles
    void SpawnObjects ()
    {

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(objectPrefabs[0], spawnPos, objectPrefabs[0].transform.rotation);
        }

        /*// Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver == false)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }*/

    }
}
