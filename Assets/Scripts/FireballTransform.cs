using UnityEngine;
using System.Collections;

public class FireballTransform : MonoBehaviour {

	public GameObject Explosion;

	// Use this for initialization
	void Start () {
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back * 10f * Time.deltaTime);
	}

	void OnCollisionEnter(Collision otherGameObject)
	{
		if(otherGameObject.gameObject.CompareTag("Player"))
		{
			gameObject.SetActive(false);
			Instantiate(Explosion, transform.position, Quaternion.identity);
		}
	}
}
