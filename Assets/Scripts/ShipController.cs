using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	private Vector3 position;
	private LasersController lasers;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		GameObject laser = GameObject.Find ("Lasers"); 
		this.lasers = laser.GetComponent<LasersController>(); 
		this.position = this.transform.position;
		rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){
		if (Input.GetAxis ("Horizontal") > 0) {
			rb.AddForce (transform.right * 50);
		} else if (Input.GetAxis ("Horizontal") < 0) {
			rb.AddForce (transform.right * -50);
		} else if (Input.GetAxis ("Vertical") > 0) {
			rb.AddForce (transform.up * 50);	
		} else if (Input.GetAxis ("Vertical") < 0) {
			rb.AddForce (transform.up * -50);	
		} else {
			rb.velocity=new Vector3(0,0,0);
		}
		if (Input.GetKey (KeyCode.Space)) {
			this.lasers.shotLasers();
		}
	}



}