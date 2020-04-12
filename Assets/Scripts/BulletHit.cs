﻿using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour
{
	private ScoreManager score;
	void Start () {
		// save the ScoreManager object as a field
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		score = player.GetComponent<ScoreManager>();
	}

	void OnTriggerEnter(Collider collidedObject)
	{
		// check if the bullet collided with a target
		if (collidedObject.tag == "Target")
		{
			// add one to the score
			score.AddToScore();
			// destroy the target
			Destroy(collidedObject.gameObject);
			// destroy the bullet
			Destroy(this.gameObject);
		}
	}
}
