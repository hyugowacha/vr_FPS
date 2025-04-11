using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject ghost;

    float spawnCoolTime = 3.0f;
    float spawnElapsedTime = 3.0f;

    private void Update()
    {
        spawnElapsedTime += Time.deltaTime;

        if(spawnCoolTime < spawnElapsedTime)
        {
            int randomPoint = Random.Range(0, 3);
            Instantiate(ghost, spawnPoints[randomPoint].transform.position, Quaternion.identity);
            spawnElapsedTime = 0;
        }
    }

}
