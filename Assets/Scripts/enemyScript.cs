using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	public float enemyHealth = 100, maxHealth = 100;

	public GameObject player;

	public GameObject mapPiece;

	public bool playerHit = false;

	public float enemySpeed = 1;

	public Transform firePoint;

	public Rigidbody fireBall;

	public float fireBallForce;

	float timer = 0;

	CharacterController controller;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			playerHit = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			playerHit = false;
		}
	}

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();

        enemyHealth = Random.Range(50, 100);
        maxHealth = enemyHealth;
    }
	
	// Update is called once per frame
	void Update () {

        if(enemyHealth <= 0)
        {
            //gameObject.GetComponent<Animator>().SetTrigger("leave");
            gameObject.SetActive(false);
        }

		if (mapPiece.GetComponent<mapPieceScript>().active == false) {

			if (!playerHit) {
				transform.LookAt (player.transform.position);

				controller.SimpleMove (transform.forward * enemySpeed);
			} else if (playerHit) {
				timer += .5f;

				transform.LookAt (player.transform.position);

				if (timer > 50 ) {

					Rigidbody tempFireBall = Instantiate (fireBall, firePoint.position, firePoint.rotation)
					as Rigidbody;

					tempFireBall.velocity = tempFireBall.transform.forward * fireBallForce;

					timer = 0;
				}
			}
		}
	}
}
