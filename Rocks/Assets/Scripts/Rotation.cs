using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float degreesPerSecond = 1; //Default to 1
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(this.transform.rotation.x, this.transform.rotation.y + degreesPerSecond, this.transform.rotation.z) * Time.deltaTime);
	}
}
