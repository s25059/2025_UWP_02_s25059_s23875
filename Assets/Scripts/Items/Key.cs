using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : ItemBase
{
    public override void Interact(PlayerController player)
    {
        player.Inventory.AddKey(this);
        Destroy(gameObject);
    }
}
