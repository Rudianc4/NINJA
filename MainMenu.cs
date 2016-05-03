using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public string startLevel;
	public string levelSelect;
	//public string btn;

	//UnityEngine.UI.Button btn = UnityEngine.Component.GetComponent<Button>();
	//GetComponent<Button >() btn = new  (GetComponent<Button>().velocity.x, jumpHeight);


	public void NewGame(){
		//btn.onClick.AddListener (() => {
			Debug.Log ("test");
		Application.LoadLevel(2);
	//	});
		//Debug.Log("load level 1");
	//	SceneManager.LoadScene(startLevel);
}
	
// Update is called once per frame
	public void LevelSelect () {
		Debug.Log("load select level");
		Application.LoadLevel(1);
}
	public void exit () {
		Debug.Log("exit cug");
		Application.Quit();
}
}
