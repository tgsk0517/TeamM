using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOverFlag = false;

    private void Start()
    {
        gameOverFlag = false;
    }

    private void GameOver()
    {
        if (gameOverFlag)
        {
            SceneManager.LoadScene("Title");
        }
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }

}