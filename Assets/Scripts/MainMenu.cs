using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Canvas QuitMenu;
	public Button StartBtn;
	public Button ExitBtn;
	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}

	void Start() {
		RestoreMainMenu();
	}

	public void OnExitPress() {
		PlayMainMenuSound ();
		QuitMenu.enabled = true;
		StartBtn.enabled=false;
		ExitBtn.enabled = false;
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
		QuitMenu.enabled = false;
		StartBtn.enabled = true;
		ExitBtn.enabled = true;
	}

	public void OnStartPress() {
		PlayMainMenuSound ();
		StartCoroutine("WaitToLoadLevel");
	}

	private void PlayMainMenuSound(){
		source.Play();
	}

	IEnumerator WaitToLoadLevel(){
		yield return new WaitForSeconds(0.6f);
		Application.LoadLevel(1);
	}

}
