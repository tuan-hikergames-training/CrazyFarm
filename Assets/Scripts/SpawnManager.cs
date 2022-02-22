using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  [SerializeField] GameObject[] animalPrefabs;
  [SerializeField] float spawnRangeX = 20;
  [SerializeField] float spawnPosZ = 20;
  [SerializeField] float startDelay = 2f;
  [SerializeField] float spawnInterval = 2f;

  void Start()
  {
    InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
  }

  void Update()
  {
  }

  void SpawnRandomAnimal()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    GameObject animal = animalPrefabs[animalIndex];
    Instantiate(animal, spawnPosition, animal.transform.rotation);
  }
}
