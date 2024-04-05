using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainInteractable : MonoBehaviour, IInteractable
{
  public string GetInteractText()
  {
    return "Open Curtain";
  }

  public Transform GetTranform()
  {
    return transform;
  }

  public void Interact(Transform interactorTransform)
  {
    Debug.Log("Curtain Opened");
  }
}
