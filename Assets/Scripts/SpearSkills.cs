using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSkills : MonoBehaviour
{
    public GameObject spear;
    public Vector3 stabForward;
    public int stabTimer;
    public int cooldown;
    public int startCooldown;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
                spear.GetComponent<Transform>().position += stabForward;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                spear.GetComponent<Transform>().position -= stabForward;
            }
        
    }
}