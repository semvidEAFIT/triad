﻿using UnityEngine;
using System.Collections;

public class DebugAim : MonoBehaviour
{

    public Color color = Color.red;
	
	// Update is called once per frame
	void LateUpdate () {
	    Debug.DrawRay(transform.position, transform.forward, color);
	}
}
