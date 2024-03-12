using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Movement")]
  [SerializeField] private float speed;

  private Rigidbody2D rb;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    var playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    var playerInputNormalized = playerInput.normalized;

    rb.velocity = playerInputNormalized * speed;

  }
}
