using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPoolManager : MonoBehaviour {

	public EnemyPool[] pools;
	public float startTime = 5.0f;
	public float repeatingTime = 1.0f;
	public float fireProbability = 0.4f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("FireEnemy", startTime, repeatingTime);	
	}
	
	void FireEnemy() {
		foreach (EnemyPool ep in pools) {	

			if (ep.HasEnemiesInPool() && Random.value <= fireProbability) {
				ep.FireEnemy();
			}
		}
	}
}
