using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSkills : MonoBehaviour
{
    public GameObject spear;
    public GameObject targetPoint;
    public GameObject spearReturn;
    private RaycastHit hit;
    public GameObject particals;
    //glow light effect
    public int chargeStages;
    public GameObject glow;
    public int chargeMid;
    public int chargeHigh;
    //cooldown variablelen
    public int cooldown;
    public int cooldownMax;
    public bool cooldownStart;
    //skill damage variabelen
    public float skilldmg;
    public float stageOne;
    public float stageTwo;
    public float stageThree;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownStart == true)
        {
            cooldown = cooldown - 1;
            if (cooldown <= 0)
            {
                cooldownStart = false;
            }
        }
        if (chargeStages == 0)
        {
            glow.GetComponent<Light>().intensity = 0.0f;
        }
        if (Input.GetButton("Fire2") && cooldown == 0)
        {
            chargeStages = chargeStages + 1;
            if(chargeStages >=1 && chargeStages <=chargeMid)
            {
                glow.GetComponent<Light>().intensity = 0.2f;
                skilldmg = stageOne;
            }
            if (chargeStages >= chargeMid && chargeStages <= chargeHigh)
            {
                glow.GetComponent<Light>().intensity = 0.6f;
                skilldmg = stageTwo;
            }
            if (chargeStages == chargeHigh && chargeStages >=chargeHigh)
            {
                glow.GetComponent<Light>().intensity = 1.2f;
                skilldmg = stageThree;
            }
            spear.GetComponent<Transform>().position = targetPoint.GetComponent<Transform>().position;
        }
        if (Input.GetButtonDown("Fire2") && cooldown != 0)
        {
            print("on cooldown");
        }
        if (Input.GetButtonUp("Fire2")&& cooldown == 0)
        {
            chargeStages = 0;
            spear.GetComponent<Transform>().position = spearReturn.GetComponent<Transform>().position;
            cooldown = cooldownMax;
            cooldownStart = true;
            if (Physics.Raycast(transform.position, -transform.forward, out hit, 10f))
            {
                if (hit.transform.tag == "Enemy")
                {
                    GameObject g = Instantiate(particals, hit.point, Quaternion.identity);
                    Destroy(g, 2);

                    hit.transform.gameObject.GetComponent<EnemyManager>().health -= skilldmg;
                }
            }

        }
        if (Input.GetButtonUp("Fire2") && cooldown != 0)
        {
            print("on cooldown");
        }
        Debug.DrawRay(transform.position, -transform.forward * 10, Color.red);

    }
}