using UnityEngine;
using UnityEngine.UI;

public class TowerStatus : MonoBehaviour
{
    [SerializeField,Header("����HP")]
    private int towerHP = 10;

    private int maxTowerHP;

    [SerializeField, Header("HP�o�[")]
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
