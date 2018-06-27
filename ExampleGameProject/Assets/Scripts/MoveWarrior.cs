using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWarrior : MonoBehaviour
{
    public float moveSpeed = 10.0f;

	// Use this for initialization
	void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
	}
}
