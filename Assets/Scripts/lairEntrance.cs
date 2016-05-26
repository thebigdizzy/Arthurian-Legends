﻿using UnityEngine;
using System.Collections;

public class lairEntrance : MonoBehaviour {

	public GameObject dragon, t1, t2, t3, t4, t5, t6, t7, t8;

	// function that will start the animations on all of the trees
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			t1.GetComponent<Animator> ().SetTrigger ("burn");
			t2.GetComponent<Animator> ().SetTrigger ("burn");
			t3.GetComponent<Animator> ().SetTrigger ("burn");
			t4.GetComponent<Animator> ().SetTrigger ("burn");
			t5.GetComponent<Animator> ().SetTrigger ("burn");
			t6.GetComponent<Animator> ().SetTrigger ("burn");
			t7.GetComponent<Animator> ().SetTrigger ("burn");
			t8.GetComponent<Animator> ().SetTrigger ("burn");
			dragon.GetComponent<Animator> ().SetTrigger ("rise");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
