using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSmash : MonoBehaviour {
    public GameObject hammer;
    public GameObject returnLocation;
    public int skilldamage;
    //skill damage
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyManager>().health -= skilldamage;
        }
        if (col.gameObject.tag == "Ground")
        {
            hammer.GetComponent<Transform>().position = returnLocation.GetComponent<Transform>().position;
            hammer.SetActive(false);
        }
    }
}
