using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {

	public GameObject player;
	public Camera camera;

//	Vector3 expectedPosition;
//	private Vector3 distanceToShip;
//	private float smoothTime = 0.3f;
//	private Vector3 velocity;
//
//	// Use this for initialization
//	void Start () {
//		velocity = Vector3.zero;
//		distanceToShip = new Vector3 (10, 10, 0);
//		getExpectedCameraPosition ();
//	}
//
//	void getExpectedCameraPosition(){
//		expectedPosition = player.transform.position + distanceToShip;
//	}
//
//	void Update () {
//		getExpectedCameraPosition ();
//		//smoothDamp acepta una velocidad maxima, puede ser util
//		Vector3 smoothposition = Vector3.SmoothDamp (camera.transform.position, expectedPosition, ref velocity, smoothTime);
//		camera.transform.position = smoothposition;
//		Debug.Log (expectedPosition);
//		Debug.Log (camera.transform.position);
//	}

	void Update(){
		camera.transform.position = player.transform.position;
	}

}