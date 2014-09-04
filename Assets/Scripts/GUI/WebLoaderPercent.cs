using UnityEngine;
using System.Collections;

public class WebLoaderPercent : MonoBehaviour {

	public float percentageLoaded = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.GetStreamProgressForLevel("GUI") == 1)
			guiText.text = "done!";
		else {
			percentageLoaded = Application.GetStreamProgressForLevel("GUI") * 100;
			guiText.text = percentageLoaded.ToString("f0");
		}
	}
}
