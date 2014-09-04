using UnityEngine;
using System.Collections;

public class InstructionsChange : MonoBehaviour {

	public GameObject currentPanelObject;
	public GameObject nextPanelObject;
	
	void OnClick() {
		NGUITools.SetActive(nextPanelObject, true);
		NGUITools.SetActive(currentPanelObject, false);
	}
}
