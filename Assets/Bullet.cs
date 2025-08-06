using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

  public GameObject bullet;

  void Start()
  {

  }

  void Update()
  {

    if (bullet.transform.position.x > 10 || bullet.transform.position.x < -10) Destroy(bullet);
    if (bullet.transform.position.y > 10 || bullet.transform.position.y < -10) Destroy(bullet);

  }
}
