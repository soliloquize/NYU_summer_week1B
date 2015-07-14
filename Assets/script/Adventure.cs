using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Adventure : MonoBehaviour {

	string currentRoom = "Balcony";
	string currentState = "You wake up on a ";
	bool hasKey = false;
	bool hasWater = false;

	
	void Update () {

		string textBuffer = currentState + currentRoom;

		if (currentRoom == "Balcony") {
			textBuffer += "\nIt is not the city view you familiar.";
			textBuffer += "\nThe air is very hot and dry.";
			textBuffer += "\nPress [W] to check the street view right down this building.";
			textBuffer += "\nPress [S] to see around to find a way out.";

			if (hasKey == true) {
				textBuffer += "" ;
			}

			if (Input.GetKeyDown(KeyCode.W) ){
				currentState = "You look down at the ";
				currentRoom = "edge of the balcony";


			} else if (Input.GetKeyDown(KeyCode.S)){
				currentState = "You find you ";
				currentRoom = "stairs";
			}


		} else if (currentRoom == "edge of the balcony") {
			textBuffer += "\nYou cannot see any ground down there. ";
			textBuffer += "\nSuddenly some floating faries fly to you. ";
			textBuffer += "\nPress [S] to step back away from them. ";
			textBuffer += "\nPress [E] to catch one of them. ";
			textBuffer += "\nPress []";

			if (Input.GetKeyDown(KeyCode.S)){
				currentState = "You are back to the center of the ";
				currentRoom = "Balcony";

			} else if (Input.GetKeyDown (KeyCode.E)){



			} else if (Input.GetKeyDown (KeyCode.W)){



			}

		} else if (currentRoom == "stairs") {
			textBuffer += " ";
			textBuffer += " ";
			textBuffer += " ";

			if (hasKey == true) {
				textBuffer += "" ;
			}

		}

		gameObject.GetComponent<Text>().text = textBuffer;


	}

}
