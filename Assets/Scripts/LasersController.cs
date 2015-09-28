using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LasersController : MonoBehaviour {

	private List<LaserControl> laserList = new List<LaserControl>();
	private AudioSource source;	
	void Awake(){
		source = this.GetComponent<AudioSource> ();
	}

	void Start () {
		for( int i = 0; i< this.transform.childCount; i++){
			laserList.Add(this.transform.GetChild(i).gameObject.GetComponent<LaserControl>());
		}
	}

	void Update () {
	
	}

	public void shotLasers(){
		foreach(LaserControl laser in laserList){
			source.Play();
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
