using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDController : MonoBehaviour {

	float score = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponentInChildren<Text> ().text = "Score: " + score.ToString ();
	}

	public void setScore(float score){
		this.score = score;
	}

	public float getScore(){
		return this.score;
	}

}
