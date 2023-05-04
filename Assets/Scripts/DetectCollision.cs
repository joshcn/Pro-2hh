﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour 
{



	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
	

		if(!other.gameObject.CompareTag("Farmer")){

			Points.instance.AddPoint();
			Destroy(other.gameObject);
			Destroy(gameObject);
			
 		}
		else
		{
			Points.instance.DecreaseLives();

			Destroy(other.gameObject);
			Destroy(gameObject);
			
		}
	}
}
