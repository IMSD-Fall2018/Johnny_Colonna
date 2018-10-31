using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {


    private Renderer rend;
   
    void Start()
    {
        rend = GetComponent<Renderer>();
        InvokeRepeating("RandomColor", 1f, 1f);
    }
    void RandomColor()
    {
        rend.material.color = Random.ColorHSV();
    }

}
