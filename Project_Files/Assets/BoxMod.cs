using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMod : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if (Input.GetMouseButton(1))
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }

    }
}
