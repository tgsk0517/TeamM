using UnityEngine;
using UnityEngine.UI;

public class TowerStatus : MonoBehaviour
{
    public float towerHP = 10;

    private float maxTowerHP;

    [SerializeField, Header("HPƒo[")]
    private Slider sliderRef;

    private void Start()
    {
        maxTowerHP = towerHP;
    }

    public void Damage()
    {
        if(towerHP > 0)
        {
            towerHP = towerHP - 1.0f;
            sliderRef.value = towerHP / maxTowerHP;

        }

    }
}
