using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum TypeOfEnemy {Asteroid, SimpleSpaceShip}; 

public class GameController : MonoBehaviorSingleton<GameController> {

	int score;
	public Text scoreText;

	void Start () {
		score = 0;
		UpdateScore ();
	}

	public void AddScore(TypeOfEnemy enemy){
		if (enemy == TypeOfEnemy.Asteroid) {
			score += 10;
		} else if (enemy == TypeOfEnemy.SimpleSpaceShip) {
			score+=30;
		}
		UpdateScore ();
	}
	
	void UpdateScore () {
		scoreText.text = "Score: " + score;

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
