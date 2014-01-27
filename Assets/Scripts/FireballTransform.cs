using UnityEngine;
using System.Collections;

public class FireballTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back * 10f * Time.deltaTime);
	}
}
