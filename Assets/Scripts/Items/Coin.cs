using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ItemBase
{
    [SerializeField] private int value = 1;
    
    public override void Interact(PlayerController player)
    {
        player.Inventory.AddCoins(value);
        Destroy(gameObject);
    }
}