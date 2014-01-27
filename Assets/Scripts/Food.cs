using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	public Vector3 offset, rotationVelocity;
	public float recycleOffset, spawnChance;

	public AudioClip pickup;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		/*if(transform.localPosition.x + recycleOffset < PlatformTransform.distanceTraveled){
			gameObject.SetActive(false);
			return;
		}*/
		transform.Rotate(rotationVelocity * Time.deltaTime);
	}

	/*public void SpawnIfAvailable (Vector3 position) {
		if(gameObject.activeSelf || spawnChance <= Random.Range(0f, 100f)) {
			return;
		}
		transform.localPosition = position + offset;
		gameObject.SetActive(true);
		print("active");
	}*/

	void OnTriggerEnter () {
		PlatformTransform.AddFood();
		//gameObject.SetActive(false);
		Destroy(this.gameObject);
		AudioSource.PlayClipAtPoint(pickup, Camera.main.transform.position);
	}
}
