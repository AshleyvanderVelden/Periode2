using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTrow : MonoBehaviour
{
    public Vector3 forward;
    public int trowSpeed;
    public GameObject aim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forward * Time.deltaTime * trowSpeed);
        forward.z = aim.GetComponent<Transform>().position.z;
        forward.y = aim.GetComponent<Transform>().position.y;
        forward.x = aim.GetComponent<Transform>().position.x;
    }
}