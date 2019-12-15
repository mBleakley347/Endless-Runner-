using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Manager : MonoBehaviour
{
    public static SCR_Manager instance;
    private int score;
    private int scoreMultiplier;
    private float ScoreMultTime;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (ScoreMultTime < 0)
        {
            scoreMultiplier = 1;
        }else
        {
            ScoreMultTime -= Time.deltaTime;
        }
    }
    public void ChangeScoreMult(int change, float time)
    {
        scoreMultiplier = change;
        ScoreMultTime = time;
    }
}
