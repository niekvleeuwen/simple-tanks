using UnityEngine;
using System.Collections;

public class TankShoot : MonoBehaviour 
{
	public GameObject bullet, spawnPosObj;

	void Update ()
	{
		 if (Input.GetMouseButtonDown(0))
		{
			// create a bullet
			Instantiate(bullet, spawnPosObj.transform.position, this.transform.rotation);
		}
	}
}
