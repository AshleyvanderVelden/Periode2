using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour {
    public Vector3 r;
    public float hor;
    public float ver;
    public Vector3 v;
    public int ms;
    public Vector3 vecturTwee;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        vecturTwee.y = Input.GetAxis("Mouse X");

        transform.Rotate(vecturTwee);

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        v.x = hor;
        v.z = ver;

        transform.Translate(v/ms);
	}
}
