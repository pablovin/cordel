#pragma strict

class Barra {

var Largura : int;
var Comprimento : int ;
var textura : Texture2D;
var texturaSkill: Texture2D;
}

var Barra: Barra;

var bornalStyle : GUIStyle;
var folhetoStyle : GUIStyle;
var menuStyle : GUIStyle;

var botaoSair : GUIStyle;


var showFolheto : boolean = false;
var showBornal : boolean = false;
var showMenu : boolean = false;
var showDialogoBox : boolean = false;

var folhetoBox: GUIStyle;
var bornalBox: GUIStyle;
var menuBox: GUIStyle;

var dialogoBox : GUIStyle;


function OnGUI () {
	
	
	GUI.DrawTexture(Rect(350 , 700, 366, 56), Barra.texturaSkill);
	
	//Sinaliza se a tela do Folheto deve ficar visível ou não ao clicar no botão.
	if (GUI.Button (Rect(880 , 693, 50, 50), "", folhetoStyle)) {
		
		//Application.Quit();
		
		if(!showFolheto){
               showFolheto = true;
         } else{
               showFolheto = false;
         }
		
	}
	
	if (GUI.Button (Rect(840 , 700, 50, 50), "", bornalStyle)) {
	
		if(!showBornal){
               showBornal = true;
         } else{
               showBornal = false;
         }
	
	}
	
	if (GUI.Button (Rect(927 , 700, 50, 50), "", menuStyle)) {
		
		if(!showMenu){
               showMenu = true;
         } else{
               showMenu = false;
         }
		
	}
	
	
	if( showFolheto){
	
          (GUI.Box (Rect (200, 100, 519, 550), "",folhetoBox ));
        }
    
    if( showBornal){
          (GUI.Box (Rect (200, 100, 519, 550), "",bornalBox ));
        }
	
	if( showMenu){
	
		var buttonRect = new Rect( 435, 230, 130, 50);
		
          (GUI.Box (Rect (200, 100, 519, 550), "",menuBox ));
          if (GUI.Button (buttonRect, "",botaoSair)) {
		
			Application.Quit();
		
			}
        }
        
	
	GUI.DrawTexture(Rect(320 , 680, Barra.Comprimento, Barra.Largura), Barra.textura);
	

}

function Start () {

}

function WindowFunction (windowID : int) {
	// Draw any Controls inside the window here
}

function Update () {

}