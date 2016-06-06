using UnityEngine;
using System.Collections;

public class zoneOneScript : MonoBehaviour {

	public GameObject player, healthPU, ammoPU;

	public Transform drop1, drop2, drop3, drop4;

    public bool active;

	public bool hPUActive = false, aPUActive = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            active = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            active = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
                active = false;
        }
    }

	// Use this for initialization
	void Start () {
        active = false;
        player = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			if (player.GetComponent<playerScript> ().playerHealth <= 80) {
				if (!hPUActive) {
					int drop = Random.Range (0, 2);
					hPUActive = true;
					if (drop == 1) {
						Rigidbody tempHealthPU = Instantiate (healthPU, drop1.position, drop1.rotation)
				as Rigidbody;
					} else {
						Rigidbody tempHealthPU = Instantiate (healthPU, drop2.position, drop2.rotation)
						as Rigidbody;
					}
				}
			} else {
				hPUActive = false;
			}

			if (player.GetComponent<playerScript> ().playerAmmo <= 0) {
				if (!aPUActive & active) {
					int drop = Random.Range (0, 2);
					aPUActive = true;
					if (drop == 1) {
						Rigidbody tempAmmoPU = Instantiate (ammoPU, drop3.position, drop3.rotation)
						as Rigidbody;
					} else {
						Rigidbody tempAmmoPU = Instantiate (ammoPU, drop4.position, drop4.rotation)
						as Rigidbody;
					}
				}
			} else {
				aPUActive = false;
			}
		}
	}
}
