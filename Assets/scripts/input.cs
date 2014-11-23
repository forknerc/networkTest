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
				Ray ray;
				RaycastHit hit;
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
				if(Physics.Raycast(ray,out hit,Mathf.Infinity))
					{
						if(hit.collider.name == "droneUnit1")
							{
								Debug.Log("hit drone");
								sMgrS.addUnitToSelected(GameObject.Find("droneUnit1"));
								
							}
						else 
							{
								Debug.Log("hit ground");
								sMgrS.deselectAll();
							}
						pos = hit.point;
						//Debug.Log(hit.point);
						//Debug.DrawLine(ray.origin, hit.point, Color.red);
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
