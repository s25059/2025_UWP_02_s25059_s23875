using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : ItemBase
{
    [SerializeField] private int healAmount = 20;
    
    public override void Interact(PlayerController player)
    {
        player.Heal(healAmount);
        Destroy(gameObject);
    }
}