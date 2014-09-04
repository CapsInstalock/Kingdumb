using UnityEngine;
using System.Collections;

public class BarrelTransform : MonoBehaviour {

	public GameObject Rat;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision otherGameObject)
	{
		if(otherGameObject.gameObject.CompareTag("Floor") || transform.localPosition.y < -50)
		{
			gameObject.SetActive(false);
			//Instantiate(Rat, transform.position, Quaternion.identity);
		}
	}
}
