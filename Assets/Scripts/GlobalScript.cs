using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
