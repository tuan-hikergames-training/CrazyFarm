using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
  [SerializeField] float topBounds = 20f;
  [SerializeField] float lowerBounds = -10f;

  void Start()
  {

  }

  void Update()
  {
    if (transform.position.z > topBounds)
    {
      Destroy(gameObject);
    }
    else if (transform.position.z < lowerBounds)
    {
      Debug.Log("Game Over!");
      Destroy(gameObject);
    }
  }
}
