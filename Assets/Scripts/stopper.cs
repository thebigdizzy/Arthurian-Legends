using UnityEngine;
using System.Collections;

public class stopper : MonoBehaviour {

    public GameObject lairEntrance, player;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(player.GetComponent<playerScript>().mapNum > 2)
            {
                lairEntrance.GetComponent<BoxCollider>().isTrigger = false;
                gameObject.SetActive(false);
            }
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
