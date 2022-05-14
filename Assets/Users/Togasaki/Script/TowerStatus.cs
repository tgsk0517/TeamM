using UnityEngine;
using UnityEngine.UI;

public class TowerStatus : MonoBehaviour
{
    [SerializeField,Header("ìÉÇÃHP")]
    private int towerHP = 10;

    private int maxTowerHP;

    [SerializeField, Header("HPÉoÅ[")]
    private Slider sliderRef;

    private void Start()
    {
        maxTowerHP = towerHP;
    }

    void Damage()
    {
        towerHP--;
        sliderRef.value = towerHP / maxTowerHP;

    }
}
