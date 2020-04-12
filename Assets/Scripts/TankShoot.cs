using UnityEngine;
using System.Collections;

public class TankShoot : MonoBehaviour 
{
	public GameObject bullet, spawnPosObj;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			// create a bullet
			Instantiate(bullet, spawnPosObj.transform.position, this.transform.rotation);
		}
	}
}
