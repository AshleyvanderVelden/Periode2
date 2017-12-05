using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSmash : MonoBehaviour {
    public GameObject hammer;
    public GameObject returnLocation;
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
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Ground")
        {
            hammer.GetComponent<Transform>().position = returnLocation.GetComponent<Transform>().position;
            hammer.SetActive(false);
        }
    }
}
