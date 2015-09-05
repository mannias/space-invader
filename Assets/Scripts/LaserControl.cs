using UnityEngine;
using System.Collections;

public class LaserControl : MonoBehaviour {

	private bool isShowingLaser = false;
	private Renderer render;

	void Start() {
		this.render = this.gameObject.GetComponent<Renderer> ();
		this.render.enabled = false;
	}


	public IEnumerator showLaser()
	{

		if (isShowingLaser) {
			return true;
		}
		isShowingLaser = true;
		this.render.enabled = true;

		yield return new WaitForSeconds(.05f);

		resetLaser();


	}

	void resetLaser()
	{    
		this.render.enabled = false;
		isShowingLaser = false;
	}

}
