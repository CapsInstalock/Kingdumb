using UnityEngine;
using System.Collections;

public class KingRotate : MonoBehaviour {
	
	public GameObject RagKing;
	public AudioClip Whistle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

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
