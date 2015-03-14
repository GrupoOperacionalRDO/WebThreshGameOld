using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHPScript : MonoBehaviour {

	float playerhp;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.playerhp = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ().getHealth ();
		gameObject.GetComponent<Text> ().text = this.playerhp.ToString();
	}
}
