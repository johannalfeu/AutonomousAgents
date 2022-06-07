using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public AI Script;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Prey")
        {
            Script.chasing = true;
            Debug.Log("Colidindo");

            Script.newtarget = 2;
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Prey")
        {
            Script.chasing = false;
        }

        Script.newtarget = 0;
    }
}
