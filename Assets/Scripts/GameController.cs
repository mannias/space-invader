using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class GameController : MonoBehaviorSingleton<GameController> {

	public enum TypeOfEnemy {Asteroid, SimpleSpaceShip}; 
	
	int score;
	public Text scoreText;
	public Image life1;
	public Image life2;
	public Image life3;

	void Start () {
		score = 0;
		UpdateScore ();
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
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
