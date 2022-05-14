using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerS : TowerStats
{
    void Start()
    {
        _timer = 0.0f;
        ATKctTime = 1.0f;
        ATKct = false;
    }

    void Update()
    {
        _timer += Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("TowerCollider");
        // 攻撃範囲にEnemyタグが侵入し続けている間
        if (collider.gameObject.tag == "EnemyN")
        {
            // boolとdeltaTimeで発射間隔制御(理想はコルーチンなのかもしれない)
            ATKct = true;

            if(ATKct && _timer >= ATKctTime)
                TowerATK();

        }
    }

    private void TowerATK()
    {
        _timer = 0.0f;
        ATKct = false;
        // 弾を生成し初期座標をタワーの座標に設定
        GameObject TowerShot = Instantiate(Ammo) as GameObject;
        TowerShot.transform.position = (this.transform.position);        
    }
}
