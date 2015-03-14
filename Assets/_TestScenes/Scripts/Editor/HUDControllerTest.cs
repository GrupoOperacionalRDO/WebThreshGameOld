using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTest
{

    [TestFixture]
    [Category("HUDControllerTests")]
    internal class HUDControllerTests
	{
		[Test]
		public void TestSetScoreText(){
			//Preparation
			GameObject hud = GameObject.Instantiate(Resources.Load("Prefabs/HUD")) as GameObject;
			float randomScore = UnityEngine.Random.value * 100;
			//Action
			hud.GetComponent<HUDController> ().setScore (randomScore);
			//Assertion
			Assert.That(hud.GetComponentInChildren<UnityEngine.UI.Text>().text,Is.EqualTo("Score: " + randomScore.ToString()));
			GameObject.DestroyImmediate (hud);
		}
	}
}