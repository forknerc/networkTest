using UnityEngine;
using System.Collections;

public class selectionManager : MonoBehaviour {

	public ArrayList selectedUnits;

	// Use this for initialization
	void Start () {

		selectedUnits = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
	
		foreach(GameObject unit in selectedUnits)
		{
			unit.GetComponent<droneUnit>().drawBoundingBox();
		}

	}

	public void addUnitToSelected(GameObject unit){

		selectedUnits.Add(unit);
	}

	public void deselectAll() {

		selectedUnits.Clear();
	}
}
