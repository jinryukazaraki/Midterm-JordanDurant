﻿using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){		
		if(other.gameObject.tag=="item"){
			other.gameObject.SetActive(false);
			count = count + 1;
			CountText();
		}
		if(other.gameObject.tag=="hazard"){
			other.gameObject.SetActive(false);
			Vector3 jump = new Vector3(0.0f, 30, 0.0f);
			rigidbody.AddForce (jump * speed * Time.deltaTime);
		}
	}
}
