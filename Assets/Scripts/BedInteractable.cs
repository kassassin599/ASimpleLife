using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedInteractable : MonoBehaviour, IInteractable
{
  [SerializeField] private string interactText;

  public Transform GetTranform()
  {
    return transform;
  }

  public void Interact(Transform interactorTransform)
  {
    Debug.Log("Sleep!");
  }

  public string GetInteractText() { return interactText; }
}
