using UnityEngine;
using System.Collections;

public class EnemyShipController : EnemyController {

	public GameObject target;
	public float targetRefresh = 0.25f;
	public float flashIntensity = 3f;
	public float fadeSpeed = 10f;

	private bool firstRun = true;
	private LineRenderer laserShotLine;
	private Light laserShotLight;
	private Transform targetPosition;
	private bool shooting;

	void OnEnable() {
		base.OnEnable();
		laserShotLine = GetComponentInChildren<LineRenderer> ();
		laserShotLight = laserShotLine.gameObject.GetComponent<Light>();
		targetPosition = target.transform;
		laserShotLine.enabled = false;
		laserShotLight.intensity = 0f;
		
		firstRun = true;
		InvokeRepeating ("PullingTrigger", 0, targetRefresh);
	}

	void Update() {
		if (shooting) {
			laserShotLight.intensity = Mathf.Lerp (laserShotLight.intensity, 0f, fadeSpeed * Time.deltaTime);
		}
	}

	void PullingTrigger() {
		if (!firstRun && !shooting) {
			Shoot();
		} else {
			shooting = false;
			laserShotLine.enabled = false;
		}

		firstRun = false;
		targetPosition = target.transform;
	}

	void Shoot() {
		shooting = true;
		laserShotLine.SetPosition (0, laserShotLine.transform.position);
		laserShotLine.SetPosition (1, targetPosition.position);
		laserShotLine.enabled = true;
		laserShotLight.intensity = flashIntensity;
	}
}
