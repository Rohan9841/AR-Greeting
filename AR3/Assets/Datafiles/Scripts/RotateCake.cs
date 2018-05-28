using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCake : MonoBehaviour {

    public Vector3 rotateSpeed;

	// Use this for initialization
	void Start () {
        rotateSpeed = new Vector3(45, 20, 50);	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotateSpeed * Time.deltaTime);
	}
}
