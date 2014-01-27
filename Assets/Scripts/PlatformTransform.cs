using UnityEngine;
using System.Collections;

public class PlatformTransform : MonoBehaviour {

	public static float distanceTraveled;
	public float speed, acceleration;

	public static float score;
	public static int foodscore;


	
	// Use this for initialization
	void Start () {
		distanceTraveled = 0f;
		//GUIManager.SetDistance(distanceTraveled);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag("Player")) {
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
			speed += Time.deltaTime * acceleration;
			GUIManager.SetDistance(score);
			}
		else {
			return;	
			}
		distanceTraveled = transform.localPosition.z;
		score = distanceTraveled + foodscore;
	}
	
	public static void AddFood () {
		foodscore += 10;
	}
}