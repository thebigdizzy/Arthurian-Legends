using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

    public bool swinging = false;
	public GameObject player, sword;

    // custom function for setting the swing variable to true
    void swingCheck()
    {
        swinging = true;
    }

    // custom function for setting the swing variable to false
    void swingUnCheck()
    {
        swinging = false;
		if (player.GetComponent<playerScript> ().playerAmmo <= 0) {
			sword.GetComponent<MeshRenderer> ().enabled = false;
		}
    }

    // Use this for initialization
    void Start () {
		player = GameObject.Find ("FPSController");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<playerScript> ().playerAmmo > 0) {
			sword.GetComponent<MeshRenderer> ().enabled = true;
		}
	}
}
