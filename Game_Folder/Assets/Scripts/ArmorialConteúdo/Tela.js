#pragma strict

class Logo {
var texturaLogo : Texture2D;
var LarguraLogo = 0;
var ComprimentoLogo = 0;
var AlturaLogo = 0;
}

class Apresenta {
var texturaLogo : Texture2D;
var LarguraLogo = 0;
var ComprimentoLogo = 0;
var AlturaLogo = 0;
}

class Box {

var LarguraBox : int;
var ComprimentoBox : int ;
var AlturaBox : int ;
//var AfastamentoBox : int;
}

class BotaoOk {
////var texturaOk : Texture2D;
var LarguraOk : int;
var ComprimentoOk : int ;
var AlturaOk : int ;
////var AfastamentoOk : int;
//var buttonContent : GUIContent;
}



var Logo: Logo;

var Apresenta: Apresenta;

var Box: Box;

var BotaoJogar: BotaoOk;

private var condition = true;

private var objectLinkScriptIsAttachedTo : GameObject;

public var mySkin : GUISkin;

function OnGUI () {

	
	var buttonRect = new Rect((Screen.width/2 - 60), BotaoJogar.AlturaOk, BotaoJogar.ComprimentoOk, BotaoJogar.LarguraOk);
		
	var boxRect = new Rect((Screen.width/2 - 320), Box.AlturaBox, Box.ComprimentoBox, Box.LarguraBox);
	
	GUI.skin = mySkin;
	
	GUI.DrawTexture(Rect((Screen.width/2 - 180) , Logo.AlturaLogo, Logo.ComprimentoLogo, Logo.LarguraLogo), Logo.texturaLogo);
	
	GUI.DrawTexture(Rect((Screen.width/2 - 60) , Apresenta.AlturaLogo, Apresenta.ComprimentoLogo, Apresenta.LarguraLogo), Apresenta.texturaLogo);
	
	
	// Make a background box
	GUI.Box (boxRect,"");
//
//	//Cria a Label de Login
//	GUI.Label (Rect (335, 200, 100, 30), "Usuário:");
//	textFieldString1 = GUI.TextField (Rect (440, 200, 180, 25), textFieldString1);
//	
//	//Cria a Label de Login
//	GUI.Label (Rect (335, 225, 100, 30), "Senha:");
//	textFieldString2 = GUI.PasswordField (Rect (440, 225, 180, 25), textFieldString2,"*"[0],25);
	
	//GUI.Label (Rect ((Screen.width/2 - 30), BotaoJogar.AlturaOk, BotaoJogar.ComprimentoOk, BotaoJogar.LarguraOk), BotaoJogar.TextoOk);
	
	
	
	if (GUI.Button (buttonRect, "")) {
		
		Application.LoadLevel("Scene1");
		
	}
	
	//if (GUI.Button (Rect (480, 270, 100, 30), "Sair")) {
		// This code is executed every frame that the RepeatButton remains clicked
	//}
	
	
}


function Start () {
	Screen.SetResolution (1024, 768, true);
}

function Update () {

}