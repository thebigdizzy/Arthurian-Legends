using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startScript : MonoBehaviour {

    public void startGame(string levelToLoad)
    {
        if (levelToLoad == "quit")
        {
            Application.Quit();
        }
        else {
            Application.LoadLevel(levelToLoad);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
