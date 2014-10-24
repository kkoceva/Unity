using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {

    public Transform cylinder;
    public float capsuleSpeed = 3f;
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(cylinder.position);
        transform.position = Vector3.MoveTowards(transform.position, cylinder.transform.position, capsuleSpeed * Time.deltaTime);
	}
}
