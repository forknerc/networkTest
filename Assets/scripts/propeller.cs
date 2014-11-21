using UnityEngine;
using System.Collections;

public class propeller : MonoBehaviour {

	public float rotateSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(new Vector3(0,0,1), rotateSpeed);
	}
}
