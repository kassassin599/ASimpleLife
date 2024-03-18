using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dog : MonoBehaviour, IInteractable
{
  [SerializeField] Transform player;

  NavMeshAgent agent;

  public string GetInteractText()
  {
    return "PET!";
  }

  public Transform GetTranform()
  {
    return transform;
  }

  public void Interact(Transform interactorTransform)
  {
    Debug.Log("Start Dialogue with DOG!");
  }

  // Start is called before the first frame update
  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
    agent.updateRotation = false;
    agent.updateUpAxis = false;
  }

  // Update is called once per frame
  void Update()
  {
    agent.SetDestination(player.position);
  }
}
