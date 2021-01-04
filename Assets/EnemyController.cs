using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
	public GameObject Player;
	private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
    	agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	agent.destination = Player.transform.position;
        
    }

    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.tag == Player.tag)
    	{
    		Vector3 x = new Vector3(0,0,-15);
    		Player.transform.position = x;
    	}
    }
}
