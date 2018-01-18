using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainRotato : MonoBehaviour {

    public Vector3 az;
    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(az * speed * Time.deltaTime);
	}
}
