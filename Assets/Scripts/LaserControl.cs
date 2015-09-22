using UnityEngine;
using System.Collections;

public class LaserControl : MonoBehaviour {

	private ParticleEmitter emitter;
	private bool emitting = false;

	void Start() {
		this.emitter = this.GetComponent<ParticleEmitter> ();
		this.emitter.Emit (0);
	}

	public void showLaser() {
		this.emitter.Emit (1);
		this.emitting = true;
	}

	public bool IsEmitting() {
		return emitting;
	}

	public void HideLaser() {
		this.emitter.Emit (0);
		this.emitting = false;
	}
}
