using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    public GameObject[] Enemy;
    private int number;
    
    public float SpawnInterval = 100.0f;


    void Update()
    {
        if(Time.frameCount % SpawnInterval == 0)
        {
            float x = Random.Range(1920.0f, -1820.0f);
            float y = Random.Range(1080.0f, -1080.0f);
            Vector2 pos = new Vector2(x, y);
            number = Random.Range (0, Enemy.Length); 
 
            Instantiate(Enemy[number], pos, Quaternion.identity);
        }    
    }
 
}
