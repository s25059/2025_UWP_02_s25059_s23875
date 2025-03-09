using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IInteractable interactable = GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.Interact(GetComponent<PlayerController>());
        }
    }
}