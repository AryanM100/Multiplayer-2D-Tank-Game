using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

  [SerializeField] private GameObject shootpos;
  [SerializeField] private GameObject angle;
  [SerializeField] private float rotspeed = 2.5f;
  [SerializeField] private float delay = 0.5f;
  [SerializeField] private GameObject _bulprefab;

  public float bulspeed = 10;
  private float currentTime;
  private float diffTime;

  void Start()
  {
  }

  void Update()
  {

//    if (!IsOwner) return;

    if (Input.GetKey(KeyCode.L))
    {
      angle.transform.Rotate(1 * Vector3.forward * rotspeed);
    }

    if (Input.GetKey(KeyCode.J))
    {
      angle.transform.Rotate(-1 * Vector3.forward * rotspeed);
    }

    Fire();
  }

  private void Fire()
  {
    diffTime = Time.time - currentTime;

    if (Input.GetKey(KeyCode.Space) && diffTime > delay)
    {
      GameObject bullet = Instantiate(_bulprefab, shootpos.transform.position, angle.transform.rotation);
      Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

      rb.velocity = bulspeed * angle.transform.up;

      currentTime = Time.time;
    }
  }
}