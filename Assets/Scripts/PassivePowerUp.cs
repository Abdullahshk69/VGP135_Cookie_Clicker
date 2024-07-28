using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassivePowerUp : PowerUp
{
    float timer = 0.0f;

    private void Start()
    {
        currentCost = cost;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer>1f)
        {
            timer = 0.0f;
            GameManager.Instance.ScorePoints(currentPower);
        }
    }
}
