using UnityEngine;
using System.Collections;

public class CylinderScript : MonoBehaviour {

    public Transform cube;
    public float speedCylinder=4.5f;

	// Update is called once per frame
	void Update () {
        transform.LookAt(cube.position);
        transform.position = Vector3.MoveTowards(transform.position, cube.transform.position, speedCylinder*Time.deltaTime);
	}
}
