using UnityEngine;
using System.Collections;

public class healthPUScript : MonoBehaviour {

    public GameObject player;

    Vector3 axis = new Vector3(0,1,0);

    float angle = 1;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player.GetComponent<playerScript>().playerHealth = player.GetComponent<playerScript>().maxHealth;
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        player = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.Rotate(axis, angle);
	}
}
