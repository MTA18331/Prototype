﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpbutton : MonoBehaviour {
    GameObject go;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(target.transform.position.x);
    }
    public Transform target;
    public Transform target2;
   
    
    public void move(int input)
    {
        Vector3 pos = target.transform.position;
        pos.x = input+300; //425
        target.transform.position = pos;

        // Exit button
        Vector3 pos2 = target2.transform.position;
        pos.x = input + 700;
        pos.y = input+35;
        target2.transform.position = pos;

    }
}
