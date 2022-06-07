using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomPatrol : MonoBehaviour
{

    public AI script;

    public float timer;
    public float speed;

    public int newtarget;

    public Vector3 Target;

    // Start is called before the first frame update
    void Start()
    {
        script.Agent = gameObject.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= newtarget) 
        {
            newTarget();
            timer = 0;
        }
    }

    void newTarget() 
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 100, myX + 100);
        float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

        Target = new Vector3(xPos, gameObject.transform.position.y,zPos);

        script.Agent.SetDestination(Target);
    }

}
