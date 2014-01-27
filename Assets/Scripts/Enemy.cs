using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	private List<GameObject> randomPrefabGenerator = new List<GameObject>();

	public GameObject box;
	public GameObject barrel;
	public GameObject rat;
	public float destroyOffset;

	private int i;

	// Use this for initialization
	void Start () {


		randomPrefabGenerator.Add (box);
		randomPrefabGenerator.Add (barrel);
		randomPrefabGenerator.Add (rat);
	
		i = Random.Range(0, 3);
		Instantiate(randomPrefabGenerator[i], transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		//int i = Random.Range(1, 3);
		Debug.Log ("Current Prefab: " + randomPrefabGenerator[i]);
	}
}
