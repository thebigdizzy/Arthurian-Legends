using UnityEngine;
using System.Collections;

public class textTimerScript : MonoBehaviour {

	float timer = 0;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;

		if (timer > 5) {
			gameObject.SetActive (false);
		}
	}
}
