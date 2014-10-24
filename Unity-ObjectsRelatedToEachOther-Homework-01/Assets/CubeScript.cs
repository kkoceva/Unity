using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    public Transform sphere;
    public float speedCube = 6f;
	
    // Update is called once per frame
	void Update () {
        transform.LookAt(sphere.position);
        transform.position = Vector3.MoveTowards(transform.position, sphere.transform.position, speedCube *Time.deltaTime);
	}
}
