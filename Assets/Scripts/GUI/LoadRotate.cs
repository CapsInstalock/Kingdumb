using UnityEngine;
using System.Collections;

public class LoadRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateBy(gameObject, iTween.Hash('y', 2, "easeType", "Linear", "looptype", "loop"));
	}
}
