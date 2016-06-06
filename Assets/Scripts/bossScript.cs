using UnityEngine;
using System.Collections;

public class bossScript : MonoBehaviour
{
    public float enemyHealth, maxHealth = 150;

    public GameObject player;

    public GameObject dragon;

    public bool flying = false;

    public float enemySpeed = 0;

    public Transform firePoint;

    public Rigidbody fireBall;

    public float fireBallForce;

    float timer = 0;

    public bool active = false;

    // custom function that will turn off flying
    void flyOff()
    {
        flying = false;
    }

    // custom function that will turn on flying
    void flyOn()
    {
        flying = true;
    }

    // custom function that will fire a fireball
    void FireBall()
    {
        Rigidbody tempFireBall = Instantiate(fireBall, firePoint.position, firePoint.rotation)
               as Rigidbody;

        tempFireBall.velocity = tempFireBall.transform.forward * fireBallForce;
    }

    // ontrigger enter function
    void OnTriggerEnter(Collider other)
    {
       
    }

    // Use this for initialization
    void Start()
    {
        enemyHealth = Random.Range(100, 150);
        maxHealth = enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (flying)
        {
            transform.LookAt(player.transform.position);
        }

        //if(enemyHealth <= 0)
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
