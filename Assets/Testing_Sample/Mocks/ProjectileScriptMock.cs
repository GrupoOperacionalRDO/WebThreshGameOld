using UnityEngine;
using System.Collections;

public class ProjectileScriptMock : ProjectileScript {
	
	void OnTriggerEnter(Collider other){
		IntegrationTest.Pass ();
		base.OnTriggerEnter (other);
	}
	
}
