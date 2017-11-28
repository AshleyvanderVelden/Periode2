using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public Vector3 vecturTwee;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        vecturTwee.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(vecturTwee * Time.deltaTime * rotationSpeed);
    }
}
