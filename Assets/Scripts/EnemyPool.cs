using UnityEngine;
using System.Collections;

public class EnemyPool : MonoBehaviour {

	public GameObject prefab;
	public int poolSize = 10;
	GameObject[] enemies;

	// Use this for initialization
	void Start () {
		enemies = new GameObject[poolSize];
		for (int i = 0; i < poolSize; i++) {
			enemies[i] = (GameObject) Instantiate(prefab);
			enemies[i].SetActive(false);
		}
	}
	
	public void FireEnemy() {
		foreach (GameObject go in enemies) {
			if (!go.activeInHierarchy) {
				go.transform.position = this.transform.position;
				go.transform.rotation = this.transform.rotation;
				go.SetActive(true);
				break;
			}
		}
	}

	public bool HasEnemiesInPool() {
		foreach (GameObject go in enemies) {
			if (!go.activeInHierarchy) {
				return true;
			}
		}
		return false;
	}
}
