using UnityEngine;
using System.Collections;

public class PlayerScriptMock : PlayerScript{

	void OnTriggerEnter(Collider other){
		float beforehealth = this.health;
		base.OnTriggerEnter(other);
		if (beforehealth - this.health == 10) {
			IntegrationTest.Pass ();
		} else {
			IntegrationTest.Fail ();
		}
	}

}
