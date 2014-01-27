using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public float delay;

	// Use this for initialization
	void Start () {
		StartCoroutine (gOver ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator gOver() {
		yield return new WaitForSeconds(delay);
		Application.LoadLevel("GameOver");
	}
}
