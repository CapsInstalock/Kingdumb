using UnityEngine;
using System.Collections;

public class PlatformRotate : MonoBehaviour {
	
	public float playerSpeed = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag("Player")) {
			float HorizontalValue = Input.GetAxis ("Horizontal") * playerSpeed * playerSpeed * Time.deltaTime;
			this.transform.Rotate(Vector3.up * HorizontalValue);
		}
		else {
			return;	
		}
	}
}
