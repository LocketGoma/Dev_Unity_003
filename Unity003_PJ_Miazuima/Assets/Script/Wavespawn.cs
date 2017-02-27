using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 문제점 : 본체가 사라지면 더이상 리스폰이 안됨
public class Wavespawn : MonoBehaviour {
    public Transform Prefab01; // 1번 유닛
    public Transform Prefab02; // 2번 유닛


    public Transform spawnPoint;


    public float timeBetweenWaves = 5f; // 웨이브 시간 간격
    public int resource=10;
    public int cost = 2;
    private float countdown = 2f;
    private float cooldown = 5f;

    private int waveLevel = 1;
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //  if (countdown <= 0f)
            // {
            SpawnWave();
            //      countdown = timeBetweenWaves;
            //  }
            //  countdown -= Time.deltaTime;
        }
        if (cooldown <= 0f)
        {
            resource++;
            cooldown = 10f;
        }
        cooldown -= Time.deltaTime;
    }
    void SpawnWave()
    {
        //Debug.Log("Prepare for Wave"); 
        /*for (int i = 0; i < waveLevel; i++) // <- 요기가 비정상 작동중
        {
            while (cooldown > 0f)
            {
                cooldown -= Time.deltaTime;
                Debug.Log("cooling \n");
            }
            SpawnEnemy();
            cooldown = 1f;
          }
        waveLevel++;
        */
        if (resource <= 0)
        {
            Debug.Log("resource is empty");
        }
        else
        {
            SpawnEnemy();
            resource -= cost;
        }


    }

    void SpawnEnemy()
    {
        Instantiate(Prefab01, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("spawn \n");
    }


}
