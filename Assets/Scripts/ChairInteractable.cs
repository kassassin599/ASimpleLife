using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteractable : MonoBehaviour, IInteractable
{
  [SerializeField] private string interactText;
  public void Interact(Transform interactorTransform)
  {
    Debug.Log("SAT ON CHAIR!");
  }

  public string GetInteractText() { return interactText; }


  public Transform GetTranform()
  {
    return transform;
  }
}
