using UnityEngine;
using System.Collections;

public class WebLoader : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		if (Application.CanStreamedLevelBeLoaded("GUI"))
			Application.LoadLevel("GUI");
		}
}
