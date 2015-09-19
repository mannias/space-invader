using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
	GameController gameController;

	public void onClickPause(){
		GameObject controllerObject = GameObject.FindWithTag ("GameController");
		gameController = controllerObject.GetComponent<GameController>();
		gameController.Pause ();
	}
}
