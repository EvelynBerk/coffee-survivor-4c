using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text finalScoreText;
    
    public void TriggerGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        int score = 0;
        if (ScoreManager.Instance != null)
        {
            score = ScoreManager.Instance.GetScore();
        }

        if (finalScoreText != null)
            finalScoreText.text = "Finaler Score: " + score;

        Time.timeScale = 0f;
    }
    
    public void RestartGame()
    {
        // Reset time scale before reloading
        Time.timeScale = 1f;

        // Reload the currently active scene so Restart works regardless of build index
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex);
    }
}