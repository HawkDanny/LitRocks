using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float degreesPerSecond = 1; //Default to 1
    public Material day2;

    private float startingRotation;
    private float deltaRotation;


    void Setup() {
        startingRotation = this.transform.eulerAngles.y;
    }

	void Update () {
        this.transform.Rotate(new Vector3(this.transform.rotation.x, this.transform.rotation.y + degreesPerSecond, this.transform.rotation.z) * Time.deltaTime);

        deltaRotation = Mathf.Abs(this.transform.eulerAngles.y - startingRotation);

        day2.SetFloat("Vector1_38DB6B22", Mathf.Min(deltaRotation / 360, 1.0f));
	}
}
