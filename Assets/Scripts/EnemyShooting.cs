using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

	Pool enemyPool;
	public GameObject enemyPrefab;
	public float timeShooting;
	public float numberOfShootings;
	public float numberOfEnemys;
	CounterTimer timer;
	int countfired;
	public float forceMultiplier;
	public Vector3 startPosition;

	// Use this for initialization
	void Start () {
		countfired = 0;
		enemyPool = this.GetComponent<Pool> ();
		timer = new CounterTimer (timeShooting);
		enemyPool.Initialize (enemyPrefab, 5);
		enemyPool.gameObject.transform.position=startPosition;
	}
	
	// Update is called once per frame
	void Update () {
		timer.Update (Time.deltaTime);
		if (timer.Finished && countfired<numberOfEnemys) {
			PoolGameObject enemy = enemyPool.Retrieve();
			enemy.gameObject.transform.position = this.transform.position;
			timer.Reset();
			countfired++;
		}
	}
}