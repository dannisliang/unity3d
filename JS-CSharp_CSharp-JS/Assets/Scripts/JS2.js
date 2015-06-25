/* Unity3D: JavaScript->C# or C#->JavaScript access */

//create a variable to access the C# script
private var csScript : CSharp1;

function Awake(){
	//Get the CSharp Script
	csScript = this.GetComponent("CSharp1");//Don't forget to place the 'CSharp1' file inside the 'Standard Assets' folder
}

//render text and other GUI elements to the screen
function OnGUI( ){
	//render the CSharp1 'message' variable
	GUI.Label(new Rect(10,30,500,20), csScript.message);
}