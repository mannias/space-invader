using UnityEngine;
using System.Collections;

public class EnemyShipController : EnemyController {

	public LasersController lasers;
	public GameObject target;
	public float targetRefresh;

	public Vector3 targetPosition;
	// Use this for initialization
	void Start () {
		GameObject laser = GameObject.Find ("Lasers"); 
		this.lasers = laser.GetComponent<LasersController>(); 
		InvokeRepeating ("Lasers", 0, targetRefresh);
	}

	void Lasers() {
		if (lasers.IsEmitting ()) {
			lasers.StopLasers ();
		} else {
			lasers.transform.LookAt(targetPosition);
			lasers.shotLasers();
		}
		targetPosition = new Vector3(target.transform.position.x, 
		                             target.transform.position.y, 
		                             target.transform.position.z);
	}
}
