﻿using UnityEngine;
using System.Collections;

public class ColliderCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "GameController") {
			Debug.Log("woop");
		}
	}
}
