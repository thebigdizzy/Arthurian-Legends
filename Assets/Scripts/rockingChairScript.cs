using UnityEngine;
using System.Collections;

public class rockingChairScript : MonoBehaviour {

	// ontriggerenter function
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			gameObject.GetComponent<Animator> ().SetTrigger ("rock");
		}
	}

	// ontriggerstay function
	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			gameObject.GetComponent<Animator> ().SetTrigger ("rock");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
