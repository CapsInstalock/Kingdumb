using UnityEngine;
using System.Collections;

public class Scoretext : MonoBehaviour {

	int score;
	public UILabel scoreText;

	// Use this for initialization
	void Start () {
		GetComponent<UILabel>().text = PlatformTransform.score.ToString("f0");
	}
}
