using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{

    public GameObject preyPrefab;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11),5,Random.Range(-10,11));
            Instantiate(preyPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
