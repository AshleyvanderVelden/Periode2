using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour {
    public GameObject enemy;
    public float playerdamage;
	// Use this for initialization
	void Start () {
        enemy = GameObject.Find("Enemy");
    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionEnter(Collision col)
    {   
     
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyManager>().health -= playerdamage;
        }
    }
}
