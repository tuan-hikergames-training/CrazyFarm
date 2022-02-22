using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float moveSpeed = 15f;
  [SerializeField] float horizontalBound = 20f;
  [SerializeField] GameObject projectilePrefab;

  private float _horizontalInput;

  void Start()
  {

  }

  void Update()
  {
    _horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(moveSpeed * _horizontalInput * Time.deltaTime * Vector3.right);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      // Throw Pizza
      Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }

    // Keep the player in bounds
    if (transform.position.x < -horizontalBound)
    {
      transform.position = new Vector3(-horizontalBound, transform.position.y, transform.position.z);
    }
    else if (transform.position.x > horizontalBound)
    {
      transform.position = new Vector3(horizontalBound, transform.position.y, transform.position.z);
    }
  }
}
