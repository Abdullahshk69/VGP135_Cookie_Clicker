using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassivePowerUp : MonoBehaviour
{
    [SerializeField] private int baseCost;
    [SerializeField] private int basePower;

    float timer = 0.0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer>1f)
        {
            timer = 0.0f;
            GameManager.Instance.ScorePoints(basePower);
        }
    }

    public void OnUpgrade()
    {
        if(GameManager.Instance.points >= baseCost)
        {
            GameManager.Instance.ScorePoints(-baseCost);
            baseCost *= baseCost;
            basePower *= 2;
        }
    }
}
