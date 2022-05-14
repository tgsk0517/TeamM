using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOverFlag = false;

    private void Start()
    {
        gameOverFlag = false;
    }

    public void GameOver()
    {
        if (gameOverFlag)
        {
            SceneManager.LoadScene("Title");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }

}