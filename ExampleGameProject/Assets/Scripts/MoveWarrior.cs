using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWarrior : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    public int facing = 0; //0 = up, 1 = right, 2 = down, 3 = left

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
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(facing > 0 )
            {
                facing++;
            }
            else
            {
                facing = 3;
            }
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            if(facing < 3)
            {
                facing++;
            }
            else
            {
                facing = 0;
            }
        }

        
        switch(facing)
        {
            case 0:
                facing = 3;
                Debug.Log("Facing = " + facing);
                break;

            case 1:
                facing = 0;
                Debug.Log("Facing = " + facing);
                break;

            case 2:
                facing = 3;
                Debug.Log("Facing = " + facing);
                break;

            case 3:
                facing = 0;
                Debug.Log("Facing = " + facing);
                break;

            default: break;
        }
        

        switch(facing)
        {
            case 0:
                //transform.Rotate(Vector3.up);
                transform.rotation.Set(0, 0, 0, 0);
                break;

            case 1:
                //transform.Rotate(Vector3.right);
                transform.rotation.Set(90, 0, 0, 0);
                break;

            case 2:
                transform.rotation.Set(180, 0, 0, 0);
                break;

            case 3:
                transform.rotation.Set(-90, 0, 0, 0);
                break;

            default: break;
        }
	}
}
