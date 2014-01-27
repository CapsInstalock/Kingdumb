using UnityEngine;
using System.Collections;

public class FoodManager : MonoBehaviour {
	
	public GameObject food;
	public int maxMinions;
	public float spawnerRate;
	
	//private int counter;
	private int numberOfMinions = 0;
	
	private float x, y, z;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (CreateFood ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	IEnumerator CreateFood () {
		while (maxMinions > numberOfMinions) {
			//numberOfMinions++;
			//Debug.Log ("Minions: " + numberOfMinions);
			
				x = Random.Range (6.0f, -6.0f);
				y = 3.61f;
				z = PlatformTransform.distanceTraveled + 10;
			
			Vector3 position = transform.position = new Vector3(x, y, z);
			Instantiate (food, position, Quaternion.identity);
			yield return new WaitForSeconds(spawnerRate);
		}
	}
}
