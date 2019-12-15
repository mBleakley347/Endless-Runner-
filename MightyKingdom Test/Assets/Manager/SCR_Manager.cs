using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_Manager : MonoBehaviour
{
    public static SCR_Manager instance;
    private float score;
    private int scoreMultiplier;
    private float ScoreMultTime;
    [SerializeField] private Text scoreText;
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

    void FixedUpdate()
    {
        score += scoreMultiplier * Time.fixedDeltaTime;
        scoreText.text = "Score : " + score ;
    }
    public void ChangeScoreMult(int change, float time)
    {
        scoreMultiplier = change;
        ScoreMultTime = time;
    }

    public void End()
    {
        PlayerPrefs.SetFloat("Score", score);
        SceneManager.LoadScene("GameOver");
    }
}
