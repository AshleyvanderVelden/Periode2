using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour {
    public Vector3 r;
    public float hor;
    public float ver;
    public Vector3 v;
    public float movementSpeed;
    public float rotateSpeed;
    public Vector3 vectorTwee;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        vectorTwee.y = Input.GetAxis("Mouse X");

        transform.Rotate(vectorTwee * Time.deltaTime*rotateSpeed);

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        v.x = hor;
        v.z = ver;

        transform.Translate(v * Time.deltaTime * movementSpeed);
	}
}
