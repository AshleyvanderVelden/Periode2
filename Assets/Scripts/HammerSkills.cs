using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSkills : MonoBehaviour
{
    public bool weaponSwitch;
    //hammer
    public GameObject hammer;
    public GameObject liftUp;
    public GameObject returnpoint;
    //skill 2 variabelen hammer
    public GameObject skill;
    public GameObject areaOfEffect;
    //spear
    public GameObject spear;
    public GameObject targetPoint;
    public GameObject spearReturn;
    //cooldown voor skill
    public int cooldown;
    public int cooldownMax;
    public bool cooldownStart;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        weaponSwitch = GetComponent<SwitchWeapon>().weapons;

        //hammer skills
        if (weaponSwitch == false)
        {   
            if(cooldownStart == true)
            {
                cooldown = cooldown - 1;
                if (cooldown <= 0)
                {
                    cooldownStart = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                hammer.GetComponent<Transform>().position = liftUp.GetComponent<Transform>().position;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                hammer.GetComponent<Transform>().position = returnpoint.GetComponent<Transform>().position;
            }
            if (Input.GetButton("Fire2") && cooldown == 0)
            {
                areaOfEffect.SetActive(true);
            }
            if (Input.GetButtonDown("Fire2") && cooldown != 0)
            {
                print("on cooldown");
            }
            if (Input.GetButtonUp("Fire2") && cooldown == 0)
            {
                cooldown = cooldownMax;
                areaOfEffect.SetActive(false);
                skill.SetActive(true);
                cooldownStart = true;
            }
            if (Input.GetButtonUp("Fire2") && cooldown != 0)
            {   
                print("on cooldown");
            }
        }
        //spear skills
        if (weaponSwitch == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                spear.GetComponent<Transform>().position = targetPoint.GetComponent<Transform>().position;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                spear.GetComponent<Transform>().position = spearReturn.GetComponent<Transform>().position;
            }
        }
    }
}