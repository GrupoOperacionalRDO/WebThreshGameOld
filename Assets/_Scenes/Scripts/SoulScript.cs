using UnityEngine;
using System.Collections;

public class SoulScript : MonoBehaviour {

	public float speed;
	
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ().velocity = transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	protected void OnTriggerEnter(Collider other){
		Destroy (this.gameObject);
	}
}
