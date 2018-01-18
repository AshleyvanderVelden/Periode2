using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    //movement
    public GameObject player;
    public int walkSpeed;
    //health
    public float health;
    public float golemDmg;
    //spawner
    public GameObject enemy;
    public Vector3 location;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform);
        transform.position += transform.forward * walkSpeed * Time.deltaTime;
        if (health <= 0)
        {
            player.GetComponent<PlayerHealth>().killCount += 1;
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerHealth>().playerHp -= golemDmg ;
        }
    }
}
