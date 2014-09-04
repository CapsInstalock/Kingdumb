using UnityEngine;
using System.Collections;

public class SuperKing : MonoBehaviour {
	
	public Transform platform;
	public GameObject Kingdumb;

	private bool isRunning;

	void Awake () {
		//StartCoroutine (SuperTimeOut ());
	}

	// Use this for initialization
	void Start () {
		audio.Play();
		transform.parent = platform;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isRunning) StartCoroutine(SuperTimeOut ());
	}

	IEnumerator SuperTimeOut () {
		isRunning = true;
		//Debug.Log("Coroutine Started");
		yield return new WaitForSeconds(audio.clip.length);
		//GameObject King;
		//Debug.Log("Time to go back");
		//Destroy(this.gameObject);
		//King = Instantiate(Kingdumb, transform.position, transform.rotation) as GameObject;
		//King.transform.parent = platform;
		PlatformTransform.powerup = 0;
		gameObject.SetActive(false);
		Kingdumb.gameObject.SetActive(true);
		isRunning = false;
	}
}
