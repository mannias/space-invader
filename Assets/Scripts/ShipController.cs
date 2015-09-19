using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	private Vector3 position;
	private LasersController lasers;
	private Rigidbody rb;
	GameController gameController;

	// Use this for initialization
	void Start () {
		GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
		gameController = controllerObject.GetComponent<GameController> ();
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
			rb.velocity=Vector3.zero;
		}
		if (Input.GetKey (KeyCode.Space)) {
			this.lasers.shotLasers();
		}
	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "hasCollide"){
			//nothing
		}else{
			gameController.OneLessLife ();
		}
	}
}