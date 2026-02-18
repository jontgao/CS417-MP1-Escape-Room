using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Timer Components")]
    [SerializeField] private float gameTime;
    [SerializeField] private TextMeshProUGUI timeTextBox;

    [Header("Scoreboard Components")]
    [SerializeField] private TextMeshProUGUI scoreTextBox;
    [SerializeField] private int totalMatches = 3;

    private bool isGameOver = false;
    private int currentMatches = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreboard();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            UpdateGameTimer();
        }
    }

    private void UpdateGameTimer()
    {
        gameTime -= Time.deltaTime;

        if (gameTime <= 0)
        {
            gameTime = 0;
            isGameOver = true;
            LoseGame();
        }

        var minutes = Mathf.FloorToInt(gameTime / 60);
        var seconds = Mathf.FloorToInt(gameTime - minutes * 60);

        string gameTimeClockDisplay = string.Format("{0:0}:{1:00}", minutes, seconds);

        timeTextBox.text = gameTimeClockDisplay;
    }

    private void UpdateScoreboard()
    {
        scoreTextBox.text = string.Format("Progress:{0}/{1}", currentMatches, totalMatches);
    }

    private void LoseGame()
    {
        Debug.Log("You Lose!");
    }

}
