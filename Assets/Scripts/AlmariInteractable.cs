using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmariInteractable : MonoBehaviour, IInteractable
{
  [SerializeField] private string interactText;
  public void Interact(Transform interactorTransform)
  {
    Debug.Log("ALMARI OPENED!");
  }

  public string GetInteractText() { return interactText; }


  public Transform GetTranform()
  {
    return transform;
  }
}
