using UnityEngine;
using System.Collections;

public class MovingSphere : MonoBehaviour
{
    public float speed = 7.5f;
    public float jumpSpeed = 15f;

	// Use this for initialization
	void Start () 
    {
        Debug.Log("Start");
	}

    void Awake ()
    {
        Debug.Log("Awake");
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0f, jumpSpeed * Time.deltaTime, 0f);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(0f, -jumpSpeed * Time.deltaTime, 0f);
        }
	}
}
