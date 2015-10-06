using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public enum Lives {life1, life2, life3};
	GameController gameController;
	public GameObject pausePanel;
	public GameObject gameOverPanel;
	public Text scoreText;
	public Text centralText;
	public Image life1;
	public Image life2;
	public Image life3;
	public Text pause;
	private AudioSource source;	
	
	void Awake(){
		source = this.GetComponent<AudioSource> ();
	}

	public void Start(){
		GameObject controllerObject = GameObject.FindWithTag ("GameController");
		gameController = controllerObject.GetComponent<GameController>();
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
	}

	public void onClickPause(){	
		source.Play ();
		gameController.Pause ();
	}

	public void PauseMenu(bool show){
		pausePanel.SetActive (show);
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
		gameOverPanel.gameObject.SetActive (true);
		centralText.text = "Game Over";
		Time.timeScale = 0;
	}

	public void Win(){
		centralText.gameObject.SetActive (true);
		gameOverPanel.gameObject.SetActive (true);
		centralText.text = "You win!";
	}

	public void onClickMainMenu(){
		source.Play ();
		Application.LoadLevel(0);
		//StartCoroutine("WaitToLoadMainMenu");
	}

	public void onClickPlayAgain(){
		source.Play ();
		Time.timeScale = 1;
		Application.LoadLevel(1);
		//WaitToLoadLevelOne ();//TODO: change when we have levels
	}

	public void Quit(){
		source.Play ();
		Application.Quit ();
	}

	IEnumerator WaitToLoadMainMenu(){
		yield return new WaitForSeconds(1f);
		Application.LoadLevel(0);
	}

	IEnumerator WaitToLoadLevelOne(){
		yield return new WaitForSeconds(0.6f);
		Application.LoadLevel(1);
	}
	
}
