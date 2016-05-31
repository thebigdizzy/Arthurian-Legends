using UnityEngine;
using System.Collections;

public class dragonCasingAnim : MonoBehaviour {

    public GameObject dragon;

    // custom function that will make the dragon fly
    void flyOn()
    {
        dragon.GetComponent<Animator>().SetTrigger("fly");
        dragon.GetComponent<bossScript>().flying = true;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
