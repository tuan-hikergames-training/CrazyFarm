using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
  public GameObject[] ballPrefabs;
  [SerializeField] float minSpawnInterval = 3.0f;
  [SerializeField] float maxSpawnInterval = 6.0f;

  private float spawnLimitXLeft = -22;
  private float spawnLimitXRight = 7;
  private float spawnPosY = 30;

  private float startDelay = 1.0f;
  private float spawnInterval = 4.0f;

  // Start is called before the first frame update
  void Start()
  {
    Invoke(nameof(SpawnRandomBall), spawnInterval);
  }

  // Spawn random ball at random x position at top of play area
  void SpawnRandomBall()
  {
    // Generate random ball index and random spawn position
    Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

    int ballIndex = Random.Range(0, ballPrefabs.Length);

    // instantiate ball at random spawn location
    Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

    Invoke(nameof(SpawnRandomBall), GetRandomSpawnInterval());
  }

  float GetRandomSpawnInterval()
  {
    return Random.Range(minSpawnInterval, maxSpawnInterval);
  }
}
