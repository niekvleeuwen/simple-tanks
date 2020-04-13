using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
	private float speed = 30;

	void Start()
	{
		// destroy the bullet after 5 seconds
		Invoke ("DestroyBullet", 5);
	}

	void Update ()
	{
		// update the position of the bullet
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void DestroyBullet()
	{
		Destroy (this.gameObject);
	}
}
