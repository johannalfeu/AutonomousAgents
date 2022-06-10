using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnHunter : MonoBehaviour
{

    public GameObject preyPrefab;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-35, 35), 5, Random.Range(-35, 35));
        Instantiate(preyPrefab, randomSpawnPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
