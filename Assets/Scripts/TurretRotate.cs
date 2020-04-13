using UnityEngine;
using System.Collections;

public class TurretRotate : MonoBehaviour {

    float speed = 50;
 
    void Update()
    {
        // update the position of the tanks gun
        this.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);
    }
}