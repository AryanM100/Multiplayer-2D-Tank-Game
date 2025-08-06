using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

  public Rigidbody2D rb;
  public float speed = 1;
  private float horizontal;
  private float vertical;
  private float h = 1;
  private float v = 1;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {

   // if (!IsOwner) return;

    horizontal = Input.GetAxisRaw("Vertical");
    vertical = Input.GetAxisRaw("Horizontal");

    if (vertical == -1 && h == 1)
    {
      Vector2 currentscale = transform.localScale;
      currentscale.x *= -1;
      transform.localScale = currentscale;
      h = -1;
    }
    else if (vertical == 1 && h == -1)
    {
      Vector2 currentscale = transform.localScale;
      currentscale.x *= -1;
      transform.localScale = currentscale;
      h = 1;
    }

    if (horizontal == -1 && v == 1)
    {
      Vector2 currentscale = transform.localScale;
      currentscale.y *= -1;
      transform.localScale = currentscale;
      v = -1;
    }
    else if (horizontal == 1 && v == -1)
    {
      Vector2 currentscale = transform.localScale;
      currentscale.y *= -1;
      transform.localScale = currentscale;
      v = 1;
    }

    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    rb.velocity = new Vector2(vertical * speed, rb.velocity.x);
  }

}