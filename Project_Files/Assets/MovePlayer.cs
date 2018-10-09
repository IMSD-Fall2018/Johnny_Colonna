using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {


    float movementSpeed = 5f;
    Vector3 newPosition = Vector3.zero;


    void Start () {
        newPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += (Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
        newPosition.x += (Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime);

        this.transform.position = newPosition;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movementSpeed += 5f;
        }
        if (Input.GetKeyDown(KeyCode.RightShift) & System.Math.Abs(movementSpeed) > 0)
        {
            movementSpeed -= 5f;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            newPosition = Vector3.zero;
            transform.localScale = new Vector3(5f, 5f, 5f);
            movementSpeed = 5f;
        }

        print(movementSpeed);
    }

}
