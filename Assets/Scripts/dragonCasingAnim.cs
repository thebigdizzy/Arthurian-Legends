using UnityEngine;
using System.Collections;

public class dragonCasingAnim : MonoBehaviour {

    public GameObject dragon;
    public bool isBoss = false;

    // custom function that will make the dragon fly
    void flyOn()
    {
        dragon.GetComponent<Animator>().SetTrigger("fly");
        dragon.GetComponent<bossScript>().flying = true;
    }

	// custom function for winning condition
	void Win(){
		Application.LoadLevel ("Win");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (isBoss)
        {
            if (dragon.GetComponent<bossScript>().enemyHealth <= 0)
            {
                gameObject.GetComponent<Animator>().SetTrigger("leave");
            }
        } 
	}
}
