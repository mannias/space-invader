using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviorSingleton<GameController> {

	public enum TypeOfEnemy {Asteroid, SimpleSpaceShip}; 
	int score;
	int scoreAsteroid;
	int scoreSimpleSpaceShip;
	int activeLife;
	int maxLives = 3;
	UIController uiController;
	public AudioClip gameOverSound;
	private AudioSource source;	

	void Awake(){
		source = this.GetComponent<AudioSource> ();
	}

	void Start () {
		scoreAsteroid = 10;
		scoreSimpleSpaceShip = 30;
		activeLife = 0;
		score = 0;
		GameObject uiControllerObject = GameObject.FindGameObjectWithTag ("UIController");
		uiController = uiControllerObject.GetComponent<UIController> ();
		uiController.UpdateScore (score);
	}

	void Update(){
		if (Input.GetKeyDown ("p")) {
			Pause ();
		}
	}

	public void Pause(){
		if (Time.timeScale==1) {
			Time.timeScale = 0;
			uiController.PauseMenu(true);
		} else {
			Time.timeScale =1;
			uiController.PauseMenu(false);
		}
	}

	public void AddScore(TypeOfEnemy enemy){
		if (enemy == TypeOfEnemy.Asteroid) {
			score += scoreAsteroid;
		} else if (enemy == TypeOfEnemy.SimpleSpaceShip) {
			score+=scoreSimpleSpaceShip;
		}
		uiController.UpdateScore (score);
	}	

	public void OneLessLife(){
		uiController.RemoveLifeImage(activeLife);
		activeLife += 1;
		if (activeLife == maxLives) {
			GameOver ();
		}
	}

	void GameOver(){
		source.PlayOneShot (gameOverSound);
		uiController.GameOver ();
		Time.timeScale = 0;
	}

}
