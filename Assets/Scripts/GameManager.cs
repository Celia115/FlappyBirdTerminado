using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TMP_Text scoreText;

    public bool isGameOver;

    private int score = 0;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Inicializar los puntos y la UI
        ResetScore();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isGameOver)
        {
            RestartGame();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Puntuación actual: " + score); // Verifica cuándo se llama
        scoreText.text = score.ToString();
    }
    private void ResetScore()
    {
        // Reinicia la puntuación y actualiza la UI
        score = 0;
        scoreText.text = score.ToString();
    }
}
