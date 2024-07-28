using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int points {  get; private set; }
    public int money { get; private set; }

    [SerializeField] TextMeshProUGUI score;

    private void Start()
    {
        Instance = this;
        points = 0;
        money = 0;
    }

    public void ScorePoints(int points)
    {
        this.points += points;
        this.money += points;
    }

    public void BuyUpgrade(int money)
    {
        this.money -= money;
    }

    private void Update()
    {
        score.text = "Money: " + money + "\n" +
                        "Points: " + points;
    }
}
