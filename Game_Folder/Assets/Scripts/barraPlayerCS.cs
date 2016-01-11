// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class barraPlayerCS : MonoBehaviour {


public int Largura;
public int Comprimento ;
public Texture2D textura;
public Texture2D texturaSkill;

public GUIStyle bornalStyle;
public GUIStyle folhetoStyle;
public GUIStyle menuStyle;

public GUIStyle botaoSair;
public GUIStyle botaoFechar;


public bool  showFolheto = false;
public bool  showBornal = false;
public bool  showMenu = false;
public bool  showDialogoBox = false;

public GUIStyle folhetoBox;
public GUIStyle bornalBox;
public GUIStyle menuBox;

public GUIStyle dialogoBox;


void  OnGUI (){
	
	
	GUI.DrawTexture( new Rect(350 , 700, 366, 56), texturaSkill);
	
	//Sinaliza se a tela do Folheto deve ficar visível ou não ao clicar no botão.
	if (GUI.Button ( new Rect(880 , 693, 50, 50), "", folhetoStyle)) {
		
		//Application.Quit();
		
		if(!showFolheto){
               showFolheto = true;
         } else{
               showFolheto = false;
         }
		
	}
	
	if (GUI.Button ( new Rect(840 , 700, 50, 50), "", bornalStyle)) {
	
		if(!showBornal){
               showBornal = true;
         } else{
               showBornal = false;
         }
	
	}
	
	if (GUI.Button ( new Rect(927 , 700, 50, 50), "", menuStyle)) {
		
		if(!showMenu){
               showMenu = true;
         } else{
               showMenu = false;
         }
		
	}
	
	
	if( showFolheto){
	
          GUI.Box ( new Rect(200, 100, 519, 550), "",folhetoBox );
		  UnityEngine.Rect buttonRect= new Rect( 635, 130, 34, 38);
			if (GUI.Button (buttonRect, "",botaoFechar)) {
		
			  showFolheto = false;
		
			}
        
		}
    if( showBornal){
          GUI.Box ( new Rect(200, 100, 519, 550), "",bornalBox );
		   
			  UnityEngine.Rect buttonRect= new Rect( 635, 130, 34, 38);
			if (GUI.Button (buttonRect, "",botaoFechar)) {
		
			  showBornal = false;
		
			}
			
        }
	
	if( showMenu){
	
		 UnityEngine.Rect buttonRect= new Rect( 435, 230, 130, 50);
		
          GUI.Box ( new Rect(200, 100, 519, 550), "",menuBox );
          if (GUI.Button (buttonRect, "",botaoSair)) {
		
			Application.Quit();
		
			}
			
			  UnityEngine.Rect buttonRect2= new Rect( 635, 130, 34, 38);
			if (GUI.Button (buttonRect2, "",botaoFechar)) {
		
			  showMenu = false;
		
			}
        }
        	
	GUI.DrawTexture( new Rect(320 , 680, Comprimento, Largura), textura);
			
	
}
	
		void showDialogue()
		{
			
			if(Dialogos.exibirOld)
			{
			    GUI.Box ( new Rect(100, 480, 800, 100), "",dialogoBox );		
				UnityEngine.Rect buttonRect2= new Rect( 850, 500, 34, 38);
				if (GUI.Button (buttonRect2, "",botaoFechar)) {
			
				  Dialogos.exibirOld = false;
			
				}
			}
			
			Debug.Log("Exibindo dialogo!");
			if(Dialogos.exibirBoy)
			{
			    GUI.Box ( new Rect(100, 480, 800, 100), "",dialogoBox );		
				UnityEngine.Rect buttonRect2= new Rect( 850, 500, 34, 38);
				if (GUI.Button (buttonRect2, "",botaoFechar)) {
			
				  Dialogos.exibirOld = false;
			
				}
			}
			
		}
	
	
	
void  Start (){

}

void  WindowFunction ( int windowID  ){
	// Draw any Controls inside the window here
				
}

void  Update (){
		showDialogue();
}
}