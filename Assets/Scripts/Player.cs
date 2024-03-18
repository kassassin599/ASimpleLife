using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Movement")]
  [SerializeField] private float speed;
  [SerializeField] private float interactableRadius;

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

    if (Input.GetKeyDown(KeyCode.E))
    {
      IInteractable interactable = GetInteractableObject();
      if (interactable != null)
      {
        interactable.Interact(transform);
      }
    }
  }

  public IInteractable GetInteractableObject()
  {
    List<IInteractable> interactableList = new List<IInteractable>();

    Collider2D[] colliderArray = Physics2D.OverlapCircleAll(transform.position, interactableRadius);

    foreach (var collider in colliderArray)
    {
      if (collider.TryGetComponent(out IInteractable interactable))
      {
        interactableList.Add(interactable);
      }
    }

    IInteractable closestInteractable = null;
    foreach (IInteractable interactable in interactableList)
    {
      if (closestInteractable == null)
      {
        closestInteractable = interactable;
      }
      else
      {
        if (Vector3.Distance(transform.position, interactable.GetTranform().position) <
          Vector3.Distance(transform.position, closestInteractable.GetTranform().position))
        {
          closestInteractable = interactable;
        }
      }
    }

    return closestInteractable;
  }

  private void OnDrawGizmos()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, interactableRadius);

  }
}
