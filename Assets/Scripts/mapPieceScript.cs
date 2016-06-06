using UnityEngine;
using System.Collections;

public class mapPieceScript : MonoBehaviour {

    public bool active = true;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            active = false;
            gameObject.SetActive(false);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
