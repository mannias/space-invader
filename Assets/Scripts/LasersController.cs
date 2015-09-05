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

}
