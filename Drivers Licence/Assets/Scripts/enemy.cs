using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomgenerator : MonoBehaviour
{
    public GameObject[] humanPrefabs;

    private float starDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private float spawnLimitxLeft = 0;//number not decided;
    private float spawnLimitxRight = 0; //number not decided;
    private float spawnPosY = 0;//Dont fucking know the numbers <3\


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", starDelay, spawnInterval);

    }

    // Update is called once per frame
    void SpawnRandomHuman()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitxLeft, spawnLimitxRight), spawnPosY, 0);
        int humanNumber = Random.Range(0, humanPrefabs.Length);
        Instantiate(humanPrefabs[humanNumber], spawnPos, humanPrefabs[humanNumber].transform.rotation);
    }
}