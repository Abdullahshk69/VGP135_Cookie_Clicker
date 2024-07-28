using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : PowerUp
{
    private void Start()
    {
        currentPower = power;
        currentCost = cost;
    }

    public void OnClick()
    {
        GameManager.Instance.ScorePoints(currentPower);
    }
}
