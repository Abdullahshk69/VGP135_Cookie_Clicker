using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int points {  get; private set; }

    [SerializeField] TextMeshProUGUI score;

    private void Start()
    {
        Instance = this;
        points = 0;
    }

    public void ScorePoints(int points)
    {
        this.points += points;
    }

    private void Update()
    {
        score.text = "Score: " + points;
    }
}
