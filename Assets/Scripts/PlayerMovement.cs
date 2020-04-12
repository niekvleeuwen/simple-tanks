using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	private float speed = 10;
	private float rotationSpeed = 30;

	void Update ()
	{
		/*
			multiply by deltaTime to make movement framerate independant
		*/

		// forward and backward movement
		if (Input.GetKey(KeyCode.W)) 
		{
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		} 
		else if(Input.GetKey(KeyCode.S))
		{
			this.transform.Translate(Vector3.back * speed * Time.deltaTime);
		}

		// rotation movement
		if (Input.GetKey (KeyCode.A)) {
			this.transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D)) {
			this.transform.Rotate(Vector3.up * rotationSpeed *  Time.deltaTime);
		}
	}
}
