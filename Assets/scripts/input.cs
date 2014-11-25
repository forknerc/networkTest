using UnityEngine;
using System.Collections;

public class input : MonoBehaviour {

	private Vector3 pos;

	public GameObject sMgr;
	public selectionManager sMgrS;

	// Use this for initialization
	void Start () {
	
		pos.x = 0;
		pos.y = 0;
		pos.z = 0;

		sMgr = GameObject.Find("selectionMgr");
		sMgrS = sMgr.GetComponent<selectionManager>();



	}
	
	// Update is called once per frame
	void Update () {


		
		if(Input.GetMouseButtonDown(0))
			{
				Ray rayL;
				RaycastHit hitL;
				rayL = Camera.main.ScreenPointToRay(Input.mousePosition);
		
				if(Physics.Raycast(rayL,out hitL,Mathf.Infinity))
					{
						if(hitL.collider.name == "droneUnit1")
							{
								Debug.Log("hit drone");
								sMgrS.addUnitToSelected(GameObject.Find("droneUnit1"));
								
							}
						else 
							{
								Debug.Log("hit ground");
								sMgrS.deselectAll();
							}
						pos = hitL.point;
					}
			}
		if(Input.GetMouseButtonDown(1))
			{
				Ray rayR;
				RaycastHit hitR;
				rayR = Camera.main.ScreenPointToRay(Input.mousePosition);
				Physics.Raycast(rayR,out hitR,Mathf.Infinity);
				if(sMgrS.unitsSelected())
					{
						pos = hitR.point;
						//string msg = "c goto ";
					}
			}
		
	}
	void OnGUI()
	{
		Rect rectObj=new Rect(40,10,200,400);
		GUIStyle style = new GUIStyle();
		style.alignment = TextAnchor.LowerLeft;
		GUI.Box(rectObj,"clicked at " + pos
		        ,style);
	}

}
