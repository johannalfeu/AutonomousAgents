using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{

    public GameObject preyPrefab;

    void Start()
    {
        

        for (int i = 0; i < 5; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-35, 35), 15, Random.Range(-35, 35));
            Instantiate(preyPrefab, randomSpawnPosition, Quaternion.identity);
        }





    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 26),5,Random.Range(-25,26));
            //Instantiate(preyPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
