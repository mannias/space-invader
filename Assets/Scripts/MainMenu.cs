using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Canvas InstructionPanel;
	public Button StartBtn;
	public Button ExitBtn;
	public Button InstructionBtn;
	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}

	void Start() {
		RestoreMainMenu();
	}

	public void OnExitPress() {
		PlayMainMenuSound ();
		InstructionPanel.enabled = true;
		StartBtn.enabled=false;
		StartBtn.gameObject.SetActive(false);
		ExitBtn.enabled = false;
		ExitBtn.gameObject.SetActive(false);
	}

	public void OnExitNoPress() {
		PlayMainMenuSound ();
		RestoreMainMenu ();
	}

	public void OnExitYesPress() {
		PlayMainMenuSound ();
		Application.Quit ();
	}

	public void RestoreMainMenu() {
		InstructionPanel.enabled = false;
		StartBtn.enabled = true;
		ExitBtn.enabled = true;
		StartBtn.gameObject.SetActive(true);
		ExitBtn.gameObject.SetActive(true);
	}

	public void OnStartPress() {
		PlayMainMenuSound ();
		Application.LoadLevel(1);
		//StartCoroutine("WaitToLoadLevel");
	}

	public void OnInstructionPressed(){
		PlayMainMenuSound ();
		InstructionPanel.gameObject.SetActive (true);
		InstructionPanel.enabled = true;
		InstructionBtn.gameObject.SetActive (false);
		StartBtn.gameObject.SetActive(false);
		ExitBtn.gameObject.SetActive(false);

	}

	public void onClicBackInstructions(){
		PlayMainMenuSound ();
		InstructionPanel.gameObject.SetActive (false);

		InstructionBtn.gameObject.SetActive (true);
		StartBtn.gameObject.SetActive(true);
		ExitBtn.gameObject.SetActive(true);
	}

	private void PlayMainMenuSound(){
		source.Play();
	}

	IEnumerator WaitToLoadLevel(){
		yield return new WaitForSeconds(0.6f);
		Application.LoadLevel(1);
	}

}
