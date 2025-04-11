using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    public GameObject startPanel;
    public GameObject spawnManager;
    public GameObject endPanel;
    public ScoreManager scoreManager;
    public Text timeText;
    public Text totalScore;

    public float StartTime;
    float TimeSet = 60.0f;
    bool gameStart = false;

    void Update()
    {
        if(gameStart == true)
        {
            StartTime += Time.deltaTime;
            timeText.text = timeText.text = $"{(int)(StartTime / 60):00} : {(int)(StartTime % 60):00}";


            if (StartTime > TimeSet)
            {
                Time.timeScale = 0;
                endPanel.SetActive(true);
                totalScore.text = scoreManager.score.ToString();
            }
        }
    }

    public void StartGame()
    {
        startPanel.SetActive(false);

        score.gameObject.SetActive(true);
        timeText.gameObject.SetActive(true);
        spawnManager.gameObject.SetActive(true);
        gameStart = true;
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene(0);
    }
    
}
