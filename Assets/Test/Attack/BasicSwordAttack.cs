﻿using UnityEngine;
using System.Collections;

public class BasicSwordAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            //Hit
        }
    }
}
