using UnityEngine;
using System.Collections;

public class hitDetectionScript : MonoBehaviour {

    public GameObject enemy;

    // on trigger enter function
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Sword")
        {
            enemy.GetComponent<enemyScript>().enemyHealth -= 20; 
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
