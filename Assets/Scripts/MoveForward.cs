using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
  [SerializeField] float speed = 20f;

  void Start()
  {

  }

  void Update()
  {
    transform.Translate(speed * Time.deltaTime * Vector3.forward);
  }
}
