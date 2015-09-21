using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
		
	Rigidbody rb;
	public float force;
		
	void OnParticleCollision(GameObject go) {
		this.Destroy();
	}

	void OnEnable() {
		rb = this.GetComponent<Rigidbody>();
		rb.AddForce (transform.forward * force, ForceMode.Impulse);
	}

	void Destroy() {
		this.gameObject.SetActive(false);
	}

	void OnDisable() {
		CancelInvoke();
	}

	void OnBecameInvisible() {
		this.Destroy();
	}
}