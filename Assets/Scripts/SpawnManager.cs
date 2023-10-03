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

    //Make animals spawn on the sides of the screen
    private float _sideSpawnMinZ = 3;
    private float _sideSpawnMaxZ = 15;
    private float _sideSpawnX = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", _startDelay, _spawnInterval);
        InvokeRepeating("SpawnAnimalRight", _startDelay, _spawnInterval);
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

    private void SpawnAnimalLeft()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(-_sideSpawnX, 0, Random.Range(_sideSpawnMinZ, _sideSpawnMaxZ));

        //Rotates animal to face to the left
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animals[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    private void SpawnAnimalRight()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(_sideSpawnX, 0, Random.Range(_sideSpawnMinZ, _sideSpawnMaxZ));

        //Rotates animal to face to the right
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(animals[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

}
