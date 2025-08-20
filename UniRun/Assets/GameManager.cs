using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager
{
    public bool IsGameOver { get ; private set; }
    private int score;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverUi;

    public void Awake()
    {
        gameOverUi.SetActive(false);
    }
    public void Update()
    {
        if (IsGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void AddScore(int add)
    {
        if(!IsGameOver)
        {
            score += add;
            scoreText.text = $"Score: {score}";
        }
    }

    public void OnPLayerDead()
    {
        IsGameOver = true;
        gameOverUi.SetActive(true);
    }
}
