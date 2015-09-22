using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LasersController : MonoBehaviour {

	private List<LaserControl> laserList = new List<LaserControl>();

	// Use this for initialization
	void Start () {
		for( int i = 0; i< this.transform.childCount; i++){
			laserList.Add(this.transform.GetChild(i).gameObject.GetComponent<LaserControl>());
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void shotLasers(){
		foreach(LaserControl laser in laserList){
			laser.showLaser();
		}
	}

	public void StopLasers() {
		foreach (LaserControl lc in laserList) {
			lc.HideLaser();
		}
	}

	public bool IsEmitting() {
		foreach (LaserControl lc in laserList) {
			if (!lc.IsEmitting()) {
				return false;
			}
		}
		return true; 
	}
}
