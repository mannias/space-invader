using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Canvas QuitMenu;
	public Button StartBtn;
	public Button ExitBtn;

	// Use this for initialization
	void Start() {
		RestoreMainMenu();
	}

	public void OnExitPress() {
		QuitMenu.enabled = true;
		StartBtn.enabled = false;
		ExitBtn.enabled = false;
	}

	public void OnExitNoPress() {
		RestoreMainMenu ();
	}

	public void OnExitYesPress() {
		Application.Quit ();
	}

	public void RestoreMainMenu() {
		QuitMenu.enabled = false;
		StartBtn.enabled = true;
		ExitBtn.enabled = true;
	}

	public void OnStartPress() {
		Application.LoadLevel(1);
	}
}
