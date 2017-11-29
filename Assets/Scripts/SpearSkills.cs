using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSkills : MonoBehaviour
{
    public GameObject spear;
    public GameObject targetPoint;
    public GameObject spearReturn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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