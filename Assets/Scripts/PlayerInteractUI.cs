using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInteractUI : MonoBehaviour
{
  [SerializeField] private GameObject containerGameObject;
  [SerializeField] private Player player;
  [SerializeField] private TextMeshProUGUI interactTextUI;

  private void Update()
  {
    if(player.GetInteractableObject() !=null)
    {
      Show(player.GetInteractableObject());
    }
    else
    {
      Hide();
    }
  }


  private void Show(IInteractable interactable)
  {
    containerGameObject.SetActive(true);
    interactTextUI.text = interactable.GetInteractText();
  }

  private void Hide()
  {
    containerGameObject.SetActive(false);
  }
}
