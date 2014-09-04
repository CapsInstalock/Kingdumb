using UnityEngine;
using System.Collections.Generic;

public class FoodSpawner : MonoBehaviour {

	List<GameObject> prefabList = new List<GameObject>();
	public GameObject Prefab1;
	public GameObject Prefab2;
	public GameObject Prefab3;

	// Use this for initialization
	void Start () {	
		prefabList.Add(Prefab1);	
		prefabList.Add(Prefab2);	
		prefabList.Add(Prefab3);	
			
		int prefabIndex = UnityEngine.Random.Range(0,3);		
		Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);
		Debug.Log("Spawner Activated");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
