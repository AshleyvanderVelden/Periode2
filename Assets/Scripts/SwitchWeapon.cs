using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour {
    public GameObject hammer;
    public GameObject shield;
    public GameObject spear;
    public GameObject target;
    public GameObject hammerLift;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Weapon1"))
        {
            hammer.SetActive(true);
            hammerLift.SetActive(true);
            shield.SetActive(true);
            spear.SetActive(false);
            target.SetActive(false);
        }
        if (Input.GetButtonDown("Weapon2"))
        {
            hammer.SetActive(false);
            hammerLift.SetActive(false);
            shield.SetActive(false);
            spear.SetActive(true);
            target.SetActive(true);
        }
    }
}
