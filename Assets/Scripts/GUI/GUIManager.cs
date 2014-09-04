using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	
	public GUIText boostsText, distanceText;
	
	private static GUIManager instance;
	
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public static void SetDistance(float distance){
		instance.distanceText.text = distance.ToString("f0");
	}

	public static void SetBoosts(int powerup){
		instance.boostsText.text = powerup.ToString();
	}
}
