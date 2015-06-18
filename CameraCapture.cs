/*************************************************
 # @Author: Icaro Magalhaes
 #
 # With this script you can capture screenShots
 #    by time using App.CaptureScreenshot( )
 #
 # Attach this to a camera gameObject;
 # Make external control to yourConditionToCapture;
 # Use ffmpeg to make a video by the screenShots;
 # Read about UNITY commandLine args;
 #
 *************************************************/

using UnityEngine;
using System;

public class CameraCapture : MonoBehaviour{

	// The folder we place all screenshots inside.
	// If the folder exists we will append numbers to create an empty folder.
	public string folder;
	public int frameRate = 30;
	string[] strArg;

	GameObject ICARO;
	Animation COMPONENT_ANIMATION;
	
	void Start( ){

		/***************************************************
		* Passes framerate by command line
		* Usage: myApp.exe folderName 30
		*     Where 30 is the frame by second capture rate
		***************************************************/
		strArg = Environment.GetCommandLineArgs();
		folder = strArg[1];
		frameRate = int.Parse(strArg[2]);
		
		Debug.Log ("Folders can be found inside "+Application.persistentDataPath);

		// Set the playback framerate! (real time doesn't influence time anymore)
		Time.captureFramerate = frameRate;
		
		// Create the folder
		System.IO.Directory.CreateDirectory(Application.persistentDataPath+"/"+folder);
		folder = Application.persistentDataPath+"/"+folder;

	}

	static bool yourConditionToCapture = false;

	void Update( ){ 

		if( yourConditionToCapture ){

			var name = string.Format("{0}/frame_{1}.png",  folder, Time.frameCount);

			//Capture the screenshot
			Application.CaptureScreenshot(name, 1);

		}

	}

}