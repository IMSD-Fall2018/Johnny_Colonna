using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKiller : MonoBehaviour {
    public float movementSpeed = 1f;
    Vector3 newPosition = Vector3.zero;
    Vector3 returnPosition= Vector3.zero;
	// Use this for initialization
	void Start () {
        newPosition = this.transform.position;
        returnPosition = newPosition;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y += (Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.y = returnPosition.y;
        }

        this.transform.position = newPosition;
	}
}
