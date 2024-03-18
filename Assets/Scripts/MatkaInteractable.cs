using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatkaInteractable : MonoBehaviour, IInteractable
{
  [SerializeField] private string interactText;
  public void Interact(Transform interactorTransform)
  {
    Debug.Log("Drink Water!");
  }

  public string GetInteractText() { return interactText; }


  public Transform GetTranform()
  {
    return transform;
  }
}
