using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {

	public float playerHealth = 100, maxHealth = 100;

	public float playerAmmo = 10, maxAmmo = 10;

	public Image middleImage;

	public Image middleAmmo;

	public int mapNum = 0;

	public Image map1, map2, map3, finishedMap, mapBorder;

	int timer = 0;
	int swingNum = 0;

	public GameObject sword;

	public GameObject enemy1, enemy2, enemy3, Boss;

	// enemy hit collider
	void OnTriggerEnter(Collider other) {
		// if the other object in the collision was the enemy
		if (other.tag == "Fire") {
			// take away the player's health
			playerHealth -= 5.0f;

			// shrink the middle image health graphic to show the new amount of health
			middleImage.fillAmount = playerHealth/maxHealth;

			// check to see if the player's health is less than or equal to zero - dead
			if (playerHealth <= 0) {

				Debug.Log ("Player is dead");
			}

			Destroy (other.gameObject);
		}

		// map pieces hit collider
		if (other.tag == "mapPiece") {
			other.gameObject.GetComponent<SphereCollider> ().enabled = false;
			other.gameObject.GetComponent<MeshRenderer> ().enabled = false;
			mapNum++;
		}

		if (other.tag == "enemyBody") {
			enemy1.GetComponent<enemyScript>().enemyHealth -= 20;

			if (enemy1.GetComponent<enemyScript> ().enemyHealth <= 0) {
				Destroy (enemy1);
			}
		}
	}

	// enemy stay function
	void OnTriggerStay(Collider other){
		if (other.tag == "Enemy") {
			//playerHealth -= 1;

			middleImage.fillAmount = playerHealth / maxHealth;

			if (playerHealth <= 0) {
				Debug.Log ("Player is dead");
			}
		}
	}

	// Use this for initialization
	void Start () {
		map1.enabled = false;
		map2.enabled = false;
		map3.enabled = false;
		finishedMap.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			if (playerAmmo > 0) {
				if (swingNum == 0) {				
					sword.GetComponent<Animator> ().SetTrigger ("swing1");
					swingNum = 1;
				} else {
					sword.GetComponent<Animator> ().SetTrigger ("swing2");
					swingNum = 0;
				}

				playerAmmo--;
				middleAmmo.fillAmount = playerAmmo / maxAmmo;
			}
		}
	
		if (mapNum > 0) {
			map1.enabled = true;
		}
		if (mapNum > 1) {
			map2.enabled = true;
		}
		if (mapNum > 2) {
			map3.enabled = true;

			if (timer <= 201) {
				timer++;
			}

			if(timer >= 200){
				finishedMap.enabled = true;
				mapBorder.enabled = false;
				map1.enabled = false;
				map2.enabled = false;
				map3.enabled = false;
			}
		}

	}
}
