using UnityEngine;
using System.Collections;

public class BarrelManager : MonoBehaviour {

	public GameObject barrel;
	public int maxBarrel;
	public float spawnerRate;
	
	//private int counter;
	private int numberOfBarrels = 0;
	
	private float x, y, z;


	void Awake () {
	}

	// Use this for initialization
	void Start () {
			StartCoroutine(CreateBarrel ());;
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator CreateBarrel () {
		while (maxBarrel > numberOfBarrels) {
			//numberOfMinions++;
			//Debug.Log ("Minions: " + numberOfMinions);

				x = Random.Range (6.0f, -6.0f);
				y = 10f;
				z = PlatformTransform.distanceTraveled + 100f;
				
				Vector3 position = transform.position = new Vector3(x, y, z);
				Instantiate (barrel, position, Quaternion.Euler(new Vector3(0, 90, 0)));
				yield return new WaitForSeconds(spawnerRate);
		}
	}
}
