using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject target;
	private Vector3 offset;
	public float damping = 1;
	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		transform.position = desiredPosition;
	}
}
