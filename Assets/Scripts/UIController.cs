using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public enum Lives {life1, life2, life3};
	GameController gameController;
	public GameObject pausePanel;
	public Text scoreText;
	public Text centralText;
	public Image life1;
	public Image life2;
	public Image life3;
	public Text pause;

	public void Start(){
		GameObject controllerObject = GameObject.FindWithTag ("GameController");
		gameController = controllerObject.GetComponent<GameController>();
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
	}

	public void onClickPause(){	
		gameController.Pause ();
	}

	public void PauseMenu(bool show){
		pausePanel.SetActive (show);
//		if(show)
//			pause.gameObject.SetActive (false);
//		else
//			pause.gameObject.SetActive (true);

	}

	public void RemoveLifeImage(int activeLife){
		if (activeLife == (int)Lives.life1) {
			life1.gameObject.SetActive (false);
		} else if (activeLife == (int)Lives.life2) {
			life2.gameObject.SetActive (false);
		} else if (activeLife == (int)Lives.life3) {
			life3.gameObject.SetActive(false);
		}
	}

	public void UpdateScore (int score) {
		scoreText.text = "Score: " + score;
	}

	public void GameOver(){
		centralText.gameObject.SetActive (true);
		centralText.text = "Game Over";
		Time.timeScale = 0;
	}

	public void onClickMainMenu(){
		Application.LoadLevel ("MainMenuScene");
	}

	public void Quit(){
		Application.Quit ();
	}
	
}
