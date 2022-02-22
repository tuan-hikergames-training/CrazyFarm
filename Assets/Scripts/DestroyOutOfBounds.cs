using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
  [SerializeField] float verticalBounds = 10f;

  void Start()
  {

  }

  void Update()
  {
    if (transform.position.z > verticalBounds)
    {
      Destroy(gameObject);
    }
  }
}
