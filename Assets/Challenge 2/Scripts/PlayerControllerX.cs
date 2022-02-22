using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  [SerializeField] float cooldown = 3f;

  private float _timer = 0f;

  void Start()
  {
    _timer = cooldown;
  }

  // Update is called once per frame
  void Update()
  {
    if (_timer < cooldown)
    {
      _timer += Time.deltaTime;
    }
    // On spacebar press, send dog
    if (_timer >= cooldown && Input.GetKeyDown(KeyCode.Space))
    {
      _timer = 0;
      Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
  }
}
