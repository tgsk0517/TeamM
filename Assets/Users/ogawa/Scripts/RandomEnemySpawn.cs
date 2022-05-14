using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    public GameObject PrefabCircle;

    void Update()
    {
        if(Time.frameCount % 60 == 0)
        {
            float x = Random.Range(2000.0f, -2000.0f);
            float y = Random.Range(1100.0f, -1100.0f);
            Vector2 pos = new Vector2(x, y);
 
            Instantiate(PrefabCircle, pos, Quaternion.identity);
        }    
    }
 
}
