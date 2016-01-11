#pragma strict

public class PlayerInfo {
var textura : Texture2D;
var Largura = 0;
var Comprimento = 0;
}

var Info : PlayerInfo;

function OnGUI () {

	GUI.DrawTexture(Rect(10 , 10, 188, 85), Info.textura);	
	

}
function Start () {

}

function Update () {

}