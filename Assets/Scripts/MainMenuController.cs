using UnityEngine;
using System.Collections;
using System.Collections;

public class MainMenuController : MonoBehaviour {
	
	public void onClickPlay(){
		Application.LoadLevel (1);
	}

	public void onClickInstructions(){
//		Application.LoadLevel (2);
	}

	public void Quit(){
		Application.Quit ();
	}
}
