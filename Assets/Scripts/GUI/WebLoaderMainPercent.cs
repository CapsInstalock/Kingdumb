using UnityEngine;
using System.Collections;

public class WebLoaderMainPercent : MonoBehaviour {

	public float percentageLoaded = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.GetStreamProgressForLevel("Main") == 1)
			guiText.text = "Done!";
		else {
			percentageLoaded = Application.GetStreamProgressForLevel("Main") * 100;
			guiText.text = percentageLoaded.ToString("f0");
		}
	}
}
