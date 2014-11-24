using UnityEngine;
using System.Collections;

public class droneUnit : MonoBehaviour {

	private UDPReceive netReader;
	
	public GameObject UDPobj;
	public UDPReceive UDPScript;
	public GameObject myCircle;

	public bool isSelected;
	
	// Use this for initialization
	void Start () {
		
		
		//netReader = FindObjectOfType(typeof(UDPReceive)); 
		UDPobj = GameObject.Find("networkControl");
		UDPScript = UDPobj.GetComponent<UDPReceive>();

		myCircle = GameObject.Find("selectionCircle1");

		isSelected = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// update drone position
		transform.position = UDPScript.getPos();
		
		// update drone orientation
		Vector3 ori = UDPScript.getOri();
		transform.rotation = Quaternion.Euler(ori.x, ori.y, ori.z);	


		if(isSelected)
			{
				myCircle.gameObject.SetActive(true);
			}
		else 
			{
				myCircle.gameObject.SetActive(false);
			}
				
	}
	
}
