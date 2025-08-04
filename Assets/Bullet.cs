using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Bullet : NetworkBehaviour
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
