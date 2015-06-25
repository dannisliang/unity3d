/* Unity3D: JavaScript->C# or C#->JavaScript access */

using UnityEngine;
using System.Collections;

public class CSharp2 : MonoBehaviour {
	//create a variable to access the JavaScript script
	private JS1 jsScript;

	void Awake( ){
		//Get the JavaScript component
		jsScript = this.GetComponent<JS1>();//Don't forget to place the 'JS1' file inside the 'Standard Assets' folder
	}

	//render text and other GUI elements to the screen
	void OnGUI( ){
		//render the JS1 'message' variable
		GUI.Label(new Rect(10,10,300,20),jsScript.message);
	}

}
