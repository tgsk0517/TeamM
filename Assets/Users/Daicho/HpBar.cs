using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    int testHp = 100;
    int testMaxHp;
    public Slider slider;
    public bool isDamage= false;
    private void Start()
    {
        slider.value = 1;
        testMaxHp = testHp;
    }

    private void Update()
    {
        if (isDamage)
        {
            int damage = Random.Range(1, 100);
            testHp -= damage;
            slider.value = (float)testHp / (float)testMaxHp;
            isDamage = false;
        }
        

    }
}
