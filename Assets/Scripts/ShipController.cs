using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	private Renderer renderer; 
	private Vector3 position;

	// Use this for initialization
	void Start () {

		this.position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			position.z += 1;
			this.transform.position = position;
		}
	}
}
