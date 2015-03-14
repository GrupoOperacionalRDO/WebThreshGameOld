using UnityEngine;
using System.Collections;

public class RespawnSoul : MonoBehaviour {
	private float z;
	private int countConstante;
	private int countTroca;
	// public somente para testes, quando for usar realmente passar para private e usar o setActiveRespawn
	public bool activeRespawn;
	public GameObject soul;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (activeRespawn)
			if (++countConstante >= countTroca) 
			{
				z = Random.Range (-1.0F, 10.0F);
				Instantiate (soul, new Vector3 (-10, 1, z), Quaternion.identity);
				countConstante = 0;
				countTroca = Random.Range (15, 40);
			}
	}

	public void setActiveRespawn(bool newActiveRespawn)
	{
		activeRespawn = newActiveRespawn;
	}
}
