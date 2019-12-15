using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_GameOverManager : MonoBehaviour
{
    [SerializeField] private Text text;
    void Start()
    {
        float temp = PlayerPrefs.GetFloat("Score");
        text.text = "Final Score : " + temp;
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
