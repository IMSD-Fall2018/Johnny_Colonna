using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {


    private Renderer rend;

    public Color col;
   
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.white;
        InvokeRepeating("RandomColor", 1f, 1f);
    }
    void RandomColor()
    {
        rend.material.color = Random.ColorHSV();
    }

}
