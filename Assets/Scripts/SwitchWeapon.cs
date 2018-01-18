using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour {
    public GameObject hammer;
    public GameObject spear;
    public GameObject target;
    public GameObject hammerLift;
    public GameObject shield;
    public bool weapons;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Weapon1"))
        {
            hammer.SetActive(true);
            hammerLift.SetActive(true);

            spear.SetActive(false);
            target.SetActive(false);
            weapons = false;
        }
        if (Input.GetButtonDown("Weapon2"))
        {
            hammer.SetActive(false);
            hammerLift.SetActive(false);
            spear.SetActive(true);
            target.SetActive(true);
            weapons = true;
        }
    }
}
