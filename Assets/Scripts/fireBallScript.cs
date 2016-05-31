using UnityEngine;
using System.Collections;

public class fireBallScript : MonoBehaviour {

	float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (timer > 300) {
			Destroy (gameObject);
		}

	}
}
