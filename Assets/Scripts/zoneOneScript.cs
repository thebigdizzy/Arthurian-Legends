using UnityEngine;
using System.Collections;

public class zoneOneScript : MonoBehaviour {

    public GameObject drop1, drop2, player;

    public bool active;


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
	
	}
}
