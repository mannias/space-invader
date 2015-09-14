using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
		
	Rigidbody rb;
	public float force;
		
	void Start () {
		rb = this.GetComponent<Rigidbody>();
	}
		
	void FixedUpdate () {
		rb.AddForce (transform.forward * force);
	}
}