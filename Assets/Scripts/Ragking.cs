using UnityEngine;
using System.Collections;

public class Ragking : MonoBehaviour {

	public float delay;
	public GameObject GameOver;
	public GameObject explosion;

	public GameObject pause;

	// Use this for initialization
	void Start () {
		StartCoroutine (explode ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision otherGameObject)
	{
		/*if(otherGameObject.gameObject.CompareTag("Floor"))
		{
			Destroy(this.gameObject);
			Instantiate(GameOver);
		}*/
	}

	IEnumerator explode() {
			yield return new WaitForSeconds(delay);
			Destroy(this.gameObject);
			Instantiate(explosion, transform.position, Quaternion.identity);
			Instantiate(GameOver);
		}
}
