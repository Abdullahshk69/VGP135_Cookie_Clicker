using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] protected int cost;
    [SerializeField] protected int power;
    [SerializeField] protected string powerUpName;
    public string PowerUpName { get { return powerUpName; } }
    public int currentCost { get; protected set; }
    public int currentPower { get; protected set; }
    public int Power {  get { return power; } }

    public void Upgrade()
    {
        if (GameManager.Instance.money >= currentCost)
        {
            GameManager.Instance.BuyUpgrade(currentCost);
            currentPower += power;
            currentCost *= cost;
        }
    }
}
