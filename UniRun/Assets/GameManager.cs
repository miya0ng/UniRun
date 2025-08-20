using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool IsGameOver { get; private set; }
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverUi;

    public void Awake()
    {
        scoreText.text = "Score: " + score;
        gameOverUi.SetActive(false);
        IsGameOver = false;
        score = 0;
    }
    private void Update()
    {
        if (IsGameOver && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Game Over! Press Escape to restart.");
            IsGameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void AddScore(int add)
    {
        if (IsGameOver) return;
        score += add;
        scoreText.text = "Score: " + score;
    }
    public void OnPlayerDead()
    {
        IsGameOver = true;
        gameOverUi.SetActive(true);
        Debug.Log("Player is dead. Game Over!");
    }
}

