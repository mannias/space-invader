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
	GameController gameController;
	public float downTime, pressTime = 0;
	public float countDown = 0.1f;
	public bool ready = false;

	// Use this for initialization
	void Start() {
		GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
		gameController = controllerObject.GetComponent<GameController> ();
		GameObject laser = GameObject.Find ("Lasers"); 
		this.lasers = laser.GetComponent<LasersController>(); 
		this.position = this.transform.position;
		rb = this.GetComponent<Rigidbody>();
	}
	

	void Update() {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			this.lasers.PlayLaserSound(false);
//		}
//		if (Input.GetKeyDown (KeyCode.Space) && ready == false) {
//			downTime = Time.time;
//			pressTime = downTime + countDown;
//			ready = true;
//		} else if (Input.GetKeyUp (KeyCode.Space)) {
//			ready = false;
//		}
//		if (Time.time >= pressTime && ready == true) {
//			this.lasers.PlayLaserSound(true);
//			ready = false;
//			pressTime=0;
//		}
	}

	void OnCollisionEnter(Collision c){
		gameController.OneLessLife ();
	}

		
	void FixedUpdate(){
		if (Input.GetAxis ("Horizontal") > 0) {
			rb.AddForce (transform.right * 50);
		} else if (Input.GetAxis ("Horizontal") < 0) {
			rb.AddForce (transform.right * -50);
		} else {
			rb.velocity=Vector3.zero;
		}
		if (Input.GetKey (KeyCode.Space)){
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

}