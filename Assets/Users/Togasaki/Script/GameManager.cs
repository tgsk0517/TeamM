using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public static bool gameOverFlag = false;

    [SerializeField, Header("“ƒ")]
    private TowerStatus TowerRef;

    [SerializeField, Header("gameover")]
    private Text gameOverObj;

    private void Start()
    {
        gameOverObj.color = new Color(0, 0, 0, 0);
    }

    private void Update()
    {
        if(TowerRef.towerHP == 0)
        {
            gameOverObj.color = new Color(1, 1, 1, 1);

        }
    }

    //public void GameOver()
    //{
    //    if (gameOverFlag)
    //    {
    //        SceneManager.LoadScene("Title");
    //    }
    //}

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene("MainGameScene");
    //}

}