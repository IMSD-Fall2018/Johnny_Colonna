using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCubes : MonoBehaviour {
    Vector3 pos ;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "cube")
        {
            Destroy(collision.gameObject);
            
           
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
