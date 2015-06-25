using UnityEngine;
using System.Collections;

public class GoToPost : MonoBehaviour {
	void OnGUI( ){
		if(GUI.Button(new Rect(70,100,150,20),"Icaro Magalhaes GITHUB!...")){
			Application.OpenURL (https://github.com/icaromag");
		}
	}
}
