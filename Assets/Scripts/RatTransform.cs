using UnityEngine;
using System.Collections;

public class RatTransform : MonoBehaviour {

	public float speed, acceleration;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		speed += Time.deltaTime * acceleration;
	}
}
