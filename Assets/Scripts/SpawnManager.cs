using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float _spawnRangeX = 20;
    private float _spawnPosZ = 20;
    private float _startDelay = 2;
    private float _spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomAnimal() {

        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);

        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }

}
