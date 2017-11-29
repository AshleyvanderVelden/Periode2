using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSkills : MonoBehaviour {
    public GameObject hammer;
    public GameObject liftUp;
    public GameObject returnpoint;
    //skill 2 variabelen V
    public GameObject projectile;
    public GameObject spawnlocation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            hammer.GetComponent<Transform>().position = liftUp.GetComponent<Transform>().position;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            hammer.GetComponent<Transform>().position = returnpoint.GetComponent<Transform>().position;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(projectile,spawnlocation.GetComponent<Transform>().position,Quaternion.identity);
        }
    }
}
