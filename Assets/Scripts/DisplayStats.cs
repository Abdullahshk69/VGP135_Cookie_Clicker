using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayStats : MonoBehaviour
{
    [SerializeField] PowerUp powerUp;
    [SerializeField] TextMeshProUGUI itemDescription;
    [SerializeField] TextMeshProUGUI itemName;

    private void Update()
    {
        itemDescription.text = "Cost: " + powerUp.currentCost + "\n" +
                                "Power: " + powerUp.Power;
        itemName.text = powerUp.PowerUpName;

    }
}
