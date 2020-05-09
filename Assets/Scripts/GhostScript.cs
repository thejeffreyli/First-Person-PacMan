using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostScript : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent; 
    public int Depart;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    	if (Time.time > Depart) {
        	agent.SetDestination(Target.position);
    	}
    	
    }
}
