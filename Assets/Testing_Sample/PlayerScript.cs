using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed;
	public float health;
	

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Projectile") {
			health -= 10;
		} else {
			health -= 20;
		}
	}

	public float getHealth(){
		return health;
	}
	
}
