using UnityEngine;
using System.Collections;

public class KeyBoard : MonoBehaviour {
	TouchScreenKeyboard keyboard;
	string InputText = "kari";
	// Use this for initialization
	void Start () {
		//this.InputText = gameObject.transform.Find ("");

		//this.keyboard = TouchScreenKeyboard.Open (this.InputText, TouchScreenKeyboardType.Default);
	}
	
	// Update is called once per frame
	void Update () {
		/*if (this.keyboard.done) {
			this.inputtedName = this.keyboard.text;
			this.InputText.guiText.text = this.InputText;

		}*/
	}

	public void OnClick(){
		this.keyboard = TouchScreenKeyboard.Open (this.InputText, TouchScreenKeyboardType.Default);
		Debug.Log ("push button");
	}
}
