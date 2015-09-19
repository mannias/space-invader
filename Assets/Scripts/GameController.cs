using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviorSingleton<GameController> {

	public enum TypeOfEnemy {Asteroid, SimpleSpaceShip}; 
	enum Lifes {life1, life2, life3};
	int score;
	public Text scoreText;
	public Image life1;
	public Image life2;
	public Image life3;
	int scoreAsteroid;
	int scoreSimpleSpaceShip;
	int activeLife;

	void Start () {
		scoreAsteroid = 10;
		scoreSimpleSpaceShip = 30;
		activeLife = 0;
		score = 0;
		UpdateScore ();
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
	}

	void Update(){
		if (Input.GetKeyDown ("p")) {
			Pause ();
		}
	}


	public void Pause(){
		if (Time.timeScale==1) {
			Time.timeScale = 0;
		} else {
			Time.timeScale =1;
		}
	}

	public void AddScore(TypeOfEnemy enemy){
		if (enemy == TypeOfEnemy.Asteroid) {
			score += scoreAsteroid;
		} else if (enemy == TypeOfEnemy.SimpleSpaceShip) {
			score+=scoreSimpleSpaceShip;
		}
		UpdateScore ();
	}
	
	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}

	public void OneLessLife(){
		if (activeLife == (int)Lifes.life1) {
			life1.gameObject.SetActive (false);
		} else if (activeLife == (int)Lifes.life2) {
			life2.gameObject.SetActive (false);
		} else if (activeLife == (int)Lifes.life3) {
			life3.gameObject.SetActive(false);
			GameOver();
		}
		activeLife += 1;
	}

	void GameOver(){

	}

	IEnumerator Countdown()
	{
		//centralText.text = "3";
		yield return new WaitForSeconds(1);
		//centralText.text = "2";
		yield return new WaitForSeconds(1);
		//centralText.text = "1";
		yield return new WaitForSeconds(1);
		//centralText.text = "Go!!!";
		yield return new WaitForSeconds(1);
		//centralText.text = "";
	}
}
