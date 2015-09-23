using UnityEngine;
using System.Collections;

public class EnemyShipController : EnemyController {

	public EnemyPool bulletsPool;
	public GameObject target;
	public float targetRefresh;

	public Vector3 targetPosition;
	private bool firstRun = true;
	// Use this for initialization
	void Start () {
		this.bulletsPool = Instantiate (bulletsPool);
		InvokeRepeating ("Shoot", 0, targetRefresh);
	}

	void Shoot() {
		Debug.Log ("Shoot!");
		if (!firstRun) {
			Debug.Log("Shooting at: " + targetPosition.ToString());
			firstRun = false;
			bulletsPool.transform.LookAt(targetPosition);
			bulletsPool.FireEnemy ();
		}
		targetPosition = new Vector3(target.transform.position.x, 
		                             target.transform.position.y, 
		                             target.transform.position.z);
	}
}
