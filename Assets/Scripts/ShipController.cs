using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	private Vector3 position;
	private LasersController lasers;

	// Use this for initialization
	void Start () {
		GameObject laser = GameObject.Find ("Lasers"); 
		this.lasers = laser.GetComponent<LasersController>(); 
		this.position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			position.z += 1;
			this.transform.position = position;
		} else if (Input.GetKey (KeyCode.S)) {
			position.z -= 1;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.Space)) {
			this.lasers.shotLasers();
		}

	}
}
