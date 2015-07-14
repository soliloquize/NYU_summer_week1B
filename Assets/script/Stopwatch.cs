using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Stopwatch : MonoBehaviour {

	public Text anotherTextObject;
	float timeElapsed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//if im holding down space bar, progress the time elapsed
		if( Input.GetKey(KeyCode.Space) ){
			timeElapsed += Time.deltaTime;
		}


		//display current time elapsed
		anotherTextObject.text = "Try to land exact on 10 " + timeElapsed.ToString("00.0000");

		if ( Input.GetKey(KeyCode.R) ){
			Application.LoadLevel(Application.loadedLevel);
		}

	}
}
