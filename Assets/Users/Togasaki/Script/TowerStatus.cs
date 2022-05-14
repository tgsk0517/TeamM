using UnityEngine;
using UnityEngine.UI;

public class TowerStatus : MonoBehaviour
{
    [SerializeField,Header("塔のHP")]
    private float towerHP = 10;

    private float maxTowerHP;

    [SerializeField, Header("HPバー")]
    private Slider sliderRef;

    [SerializeField, Header("ゲームマネージャー")]
    private GameManager gameManager;

    private void Start()
    {
        maxTowerHP = towerHP;
    }

    //private void Update()
    //{
    //    if(towerHP == 0)
    //    {
    //        gameManager.GameOver();
    //    }
    //}

    public void Damage()
    {
        if(towerHP == 0)
        {
            towerHP = towerHP - 1.0f;
            sliderRef.value = towerHP / maxTowerHP;

        }

    }
}
