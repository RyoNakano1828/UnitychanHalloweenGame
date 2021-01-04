﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public GameObject Player;
	public GameObject GoalPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindGameObjectsWithTag("Pumpkin").Length == 0)
        {
        	if(other.gameObject.tag == Player.tag)
        	{
        		GoalPanel.SetActive(true);
        	}
        }
    }
}
