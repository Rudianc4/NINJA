using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {


public string startLevel;
//public string levelSelect;


//UnityEngine.UI.Button btn = UnityEngine.Component.GetComponent<Button>();
//GetComponent<Button >() btn = new  (GetComponent<Button>().velocity.x, jumpHeight);


public void Level1(){
	Debug.Log ("level 1");
	Application.LoadLevel(2);
	
}

// Update is called once per frame
public void Level2() {
	Debug.Log("load select level");
	Application.LoadLevel(2);
}
	public void Level3() {
		Debug.Log("load select level");
		//Application.LoadLevel(1);
	}
	public void balik() {
		Debug.Log("balik ke menu utama");
		Application.LoadLevel(0);
	}
public void exit () {
	Debug.Log("exit cug");
	Application.Quit();
}
}
