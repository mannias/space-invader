using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShipController : MonoBehaviour {

	private Vector3 position;
	private LasersController lasers;
	private Rigidbody rb;
	private float zAn = 0.0f; //variable for control angles rotation
	private float zAnMax = 20.0f;
	private float zAnMin = -20.0f;
	private float speedRot = 5.0f;
	private HashSet<GameObject> collissions = new HashSet<GameObject>();

	// Use this for initialization
	void Start() {
		GameObject laser = GameObject.Find ("Lasers"); 
		this.lasers = laser.GetComponent<LasersController>(); 
		this.position = this.transform.position;
		rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update() {

	}

	void OnCollisionEnter (Collision col){

	}

		
	void FixedUpdate(){
		if (Input.GetAxis ("Horizontal") > 0) {
			rb.AddForce (transform.right * 50);
		} else if (Input.GetAxis ("Horizontal") < 0) {
			rb.AddForce (transform.right * -50);
		} else {
			rb.velocity=Vector3.zero;
		}
		if (Input.GetKey (KeyCode.Space)) {
			this.lasers.shotLasers();
		}
	}

	void LateUpdate() {
		this.transform.rotation = Quaternion.Euler (0, 0, 0); //default rotation
		if (Input.GetKey ("left") || Input.GetKey ("a")) {
			zAn = Mathf.Lerp (zAn, zAnMax, 1.0f * Time.deltaTime);
			if (zAn > zAnMax) {
				zAn = zAnMax;
			}
			this.transform.rotation = Quaternion.Euler (0, 0, zAn);
		}
		if (Input.GetKey ("right") || Input.GetKey ("d")) {
			zAn = Mathf.Lerp (zAn, zAnMin, 1.0f * Time.deltaTime);
			if (zAn < zAnMin) {
				zAn = zAnMin;
			}
			this.transform.rotation = Quaternion.Euler (0, 0, zAn);
		} else {
			zAn = Mathf.Lerp (zAn, 0, 1.0f * Time.deltaTime);
			this.transform.rotation = Quaternion.Euler (0, 0, zAn);
		}
	}

	void onCollision(){
		//game over or 1 less life
		rb.velocity = Vector3.zero;
	}
}