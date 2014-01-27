using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PrefabManager : MonoBehaviour {
	
	public List<GameObject> prefabs = new List<GameObject>();                       // This contains the different type of blocks
	private List<GameObject> blocksInLevel = new List<GameObject>();        // This contains a reference to current configuration of the block in game     
	
	
	private GameObject BlockStorage;                                                                        // This GameObject is used to organise all the instantiated cubes  
	private Vector3 lastBlockPosition = new Vector3(0,0,0);                         //
	
	// THIS IS FOR DEMONSTRATION YOU MAY REMOVE THIS
	// -------------------------------------------------------------------------------------------------------------------------------------------
	//public float speed = 0.05f;
	// -------------------------------------------------------------------------------------------------------------------------------------------
	
	public Transform cubeSpawnPoint;
	
	private int initialBlockAmount = 12;
	private int blocksAhead = 12;
	private int blockCreateAmount = 3;
	
	
	// INIT
	// -------------------------------------------------------------------------------------------------------------------------------------------
	void Start () {
		
		BlockStorage = new GameObject("Block Storage"); // Instantiates the block storage object
		
		// Error handeling for if thhe cubeSpawnPoint transform was not chosen  (avoids null reference)
		if(cubeSpawnPoint == null){
			cubeSpawnPoint = this.transform;
		}
		
		// Instantiates n amount of blocks (based on the initialBlockAmoun variable) just to populate the level at the start of game
		for (int i = 0; i < initialBlockAmount; i++) {
			CreateBlock();
		}
		
		
	}
	// -------------------------------------------------------------------------------------------------------------------------------------------
	
	void Update () {
		
		/*      This if statement checks to see if the players position ( specifically, this game object) has got the size of the cube * blockAhead
                 *       distance away form the last block. Essentially blocksAhead variable tests to see if the player is that many blocks away from hitting the end
                 * It then creates an amount of blocks based on blockCreateAmount variable ... so 3 which seems to be enough at most speeds.
                 */
		
		if(this.transform.position.z >= lastBlockPosition.z - (blocksInLevel[blocksInLevel.Count-1].transform.lossyScale.z * blocksAhead)){
			for (int i = 0; i < blockCreateAmount; i++) {
				CreateBlock();
			}
			
		}
	}
	
	/*
         * This cretes a single block and adds it to the blocksInLevel List <GameObject> : This is done to keep an eye on the order and allow you to remove
         * Blocks based on their order or loop blocks or slice parts out of the list for isolated selection.
         */
	
	void CreateBlock (){
		try {
			GameObject tmpCube = (GameObject)Instantiate(prefabs[ Random.Range(0, prefabs.Count - 1) ] );
			tmpCube.transform.parent = BlockStorage.transform;
			blocksInLevel.Add(tmpCube);
			tmpCube.transform.position = cubeSpawnPoint.position;                  
			tmpCube.transform.Translate(0.0f ,0.0f , lastBlockPosition.z + tmpCube.transform.localScale.z);
			lastBlockPosition = tmpCube.transform.position;
			
		} catch{
			print("There is an issue with the prefabs array, make sure it has at is populated and there are no empty slots.");
		}
		
	}
	
	
	// THIS IS FOR DEMONSTRATION YOU MAY REMOVE THIS
	// -------------------------------------------------------------------------------------------------------------------------------------------
	/*void FixedUpdate()
	{
		//this
		rigidbody.AddForce(transform.forward * speed, ForceMode.VelocityChange);
	}*/
	// -------------------------------------------------------------------------------------------------------------------------------------------
	
	
}