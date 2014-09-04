using UnityEngine;
using System.Collections;

public class KingRotate : MonoBehaviour {
	
	public GameObject RagKing;
	public GameObject SuperKing;
	public AudioClip Whistle;
	
	public Transform platform;
	public int powerValue;

	// Use this for initialization
	void Start () {
		transform.parent = platform;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlatformTransform.powerup == powerValue) {
			//GameObject Super;
			//PlatformTransform.powerup = 0;
			//Destroy(this.gameObject);
			gameObject.SetActive(false);
			SuperKing.gameObject.SetActive(true);
			//Super = Instantiate(SuperKing, transform.position, transform.rotation) as GameObject;
			//Super.transform.parent = platform;
		}
	}
	
	void OnCollisionEnter(Collision otherGameObject)
	{
		if(otherGameObject.gameObject.CompareTag("Enemy"))
		{
			Destroy(this.gameObject);
			Instantiate(RagKing, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint(Whistle, Camera.main.transform.position);
		}
	}
}
