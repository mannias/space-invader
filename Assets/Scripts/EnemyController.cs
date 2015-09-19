using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
		
	Rigidbody rb;
	public float force;
	public GameController.TypeOfEnemy type;
		
	void Start () {
		rb = this.GetComponent<Rigidbody>();
	}
		
	void FixedUpdate () {
		rb.AddForce (transform.forward * force);
	}

	void OnParticleCollision(GameObject go){
		PoolGameObject pooledObject = this.gameObject.GetComponent<PoolGameObject> ();
		pooledObject.Return ();
		GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
		GameController gameController = controllerObject.GetComponent<GameController> ();
		gameController.AddScore (type);
	}
}