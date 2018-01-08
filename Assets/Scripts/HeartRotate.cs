using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRotate : MonoBehaviour {
    public Vector3 circle;
    public int speed;
    public int hpUp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(circle * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerHealth>().playerHp += hpUp;
            Destroy(gameObject);
        }
    }
}
