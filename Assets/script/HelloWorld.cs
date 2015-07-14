using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	//create a Variable to remember where the text ui object is
	public Text myTextObject;

	// happen once at beginning of game ?the beginning of the scene or the whole game
	void Start () {
		Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () {

		myTextObject.text += "YO!";
	
	}
}
