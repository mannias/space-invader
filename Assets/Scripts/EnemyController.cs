using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
		
	Rigidbody rb;
	public float force;
	public GameController.TypeOfEnemy type;

	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.AddForce (transform.forward * force, ForceMode.Impulse);
	}
		
	void OnParticleCollision(GameObject go) {
		//PoolGameObject pooledObject = this.gameObject.GetComponent<PoolGameObject> ();
		//pooledObject.Return ();
		GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
		GameController gameController = controllerObject.GetComponent<GameController> ();
		gameController.AddScore (type);
		this.Destroy();
	}

	void OnMouseDown() {
		this.Destroy ();
	}

	void OnEnable() {/* Nothing so far */}

	void Destroy() {
		this.gameObject.SetActive(false);
	}

	void OnDisable() {
		CancelInvoke();
	}

	void OnBecameInvisible() {
		this.gameObject.SetActive (false);
	}

	//For asteroids that collide twice
	void OnCollisionEnter(){
		gameObject.layer = LayerMask.NameToLayer ("hadCollide");
	}
}