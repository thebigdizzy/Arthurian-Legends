using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

    public bool swinging = false;

    // custom function for setting the swing variable to true
    void swingCheck()
    {
        swinging = true;
    }

    // custom function for setting the swing variable to false
    void swingUnCheck()
    {
        swinging = false;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
