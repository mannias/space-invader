using UnityEngine;
using System.Collections;

public class LaserControl : MonoBehaviour {

	private bool isShowingLaser = false;
	private Renderer renderer;

	void Start() {
		this.renderer = this.gameObject.GetComponent<Renderer> ();
	}


	void showLaser()
	{
//		if( isShowingLaser ) return;
//		isShowingLaser = true;
//		this.renderer.enabled = true;
//		
//		yield return new WaitForSeconds(.05);
//
//		resetLaser();
//		isShowingLaser = false;
	}

	void resetLaser()
	{    
		this.renderer.enabled = false;
	}

}
