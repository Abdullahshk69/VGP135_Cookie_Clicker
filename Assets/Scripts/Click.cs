using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private int click;
    private int cost;

    private void Start()
    {
        click = 1;
        cost = 10;
    }

    public void OnClick()
    {
        GameManager.Instance.ScorePoints(click);
    }

    public void Upgrade()
    {
        if(GameManager.Instance.points >= cost)
        {
            GameManager.Instance.ScorePoints(-cost);
            click++;
            cost *= 2;
        }
    }
}
