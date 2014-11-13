using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	private UDPReceive netReader;

	public GameObject UDPobj;
	public UDPReceive UDPScript;

	// Use this for initialization
	void Start () {
	

		//netReader = FindObjectOfType(typeof(UDPReceive));
		UDPobj = GameObject.Find("networkControl");
		UDPScript = UDPobj.GetComponent<UDPReceive>();

	}
	
	// Update is called once per frame
	void Update () {

	transform.position = UDPScript.getPos();
	
	}
}
