using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Inventory Inventory { get; private set; }
    private int _hp;

    private void Awake()
    {
        Inventory = new Inventory();
    }

    public void Heal(int amount)
    {
        _hp += amount;
    }
}