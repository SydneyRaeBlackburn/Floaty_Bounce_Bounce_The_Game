using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{

    public GameObject[] tiles;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float length = 40.0f;
    private float notDelete = 30.0f;
    private int numTiles = 7;
    private int lastSpawn = 0;

    private List<GameObject> currentTiles;

    // Use this for initialization
    void Start()
    {
        currentTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Spawn(0);
        Spawn(0);
        for (int i = 0; i < numTiles; i++)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - notDelete > (spawnZ - numTiles * length))
        {
            Spawn();
            Delete();
        }
    }

    private void Spawn(int index = -1)
    {
        GameObject go;
        if (index == -1)
            go = Instantiate(tiles[RandomSpawn()]) as GameObject;
        else
            go = Instantiate(tiles[index]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += length;
        currentTiles.Add(go);
    }

    private void Delete()
    {
        Destroy(currentTiles[0]);
        currentTiles.RemoveAt(0);
    }

    private int RandomSpawn()
    {
        if (tiles.Length <= 1)
            return 0;
        int randomIndex = lastSpawn;
        while (randomIndex == lastSpawn)
        {
            randomIndex = Random.Range(0, tiles.Length);
        }
        lastSpawn = randomIndex;
        return randomIndex;
    }
}
