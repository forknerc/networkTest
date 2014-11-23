using UnityEngine;
using System.Collections;

public class droneUnit : MonoBehaviour {

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
		
		// update drone position
		transform.position = UDPScript.getPos();
		
		// update drone orientation
		Vector3 ori = UDPScript.getOri();
		transform.rotation = Quaternion.Euler(ori.x, ori.y, ori.z);	
	}
	
	public void drawBoundingBox() {
		
		//Debug.Log("drawing bounding box");
		//Gizmos.DrawWireCube(transform.position, new Vector3(0.5f, 0.5f, 0.5f));
		//OnDrawGizmos();
		
		
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube(transform.position, new Vector3(1f, 1f, 1f));
	}
}
