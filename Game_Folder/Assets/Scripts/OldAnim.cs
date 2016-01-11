using UnityEngine;
using System.Collections;

public class OldAnim : MonoBehaviour {
	
	
	OTAnimatingSprite mySprite;
	
	// Use this for initialization
	void Start () {
	mySprite = GameObject.Find("Old").GetComponent<OTAnimatingSprite>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(OldChange.currentAnim== OldChange.anim.comecoAndarDireita)
			{
				mySprite.Play("right");
		        OldChange.currentAnim = OldChange.anim.andandoDireita;
			}
			
			else if ( OldChange.currentAnim== OldChange.anim.comecoAndarEsquerda)
			{
				mySprite.Play("left");
			        OldChange.currentAnim = OldChange.anim.andandoEsquerda;
			}
			else if ( OldChange.currentAnim== OldChange.anim.comecoAndarCima)
			{
				mySprite.Play("up");
			        OldChange.currentAnim = OldChange.anim.andandoCima;
			}
			else if ( OldChange.currentAnim== OldChange.anim.comecoAndarBaixo)
			{
				mySprite.Play("down");
			        OldChange.currentAnim = OldChange.anim.andandoBaixo;
			}
			else if ( OldChange.currentAnim== OldChange.anim.ParouDireita)
			{			    
				mySprite.ShowFrame(9);
			        OldChange.currentAnim = OldChange.anim.parado;
			}
			else if ( OldChange.currentAnim== OldChange.anim.ParouEsquerda)
			{			    
				 mySprite.ShowFrame(0);
			     OldChange.currentAnim = OldChange.anim.parado;
			}
			else if ( OldChange.currentAnim== OldChange.anim.ParouCima)
			{			    
				mySprite.ShowFrame(18);
			        OldChange.currentAnim = OldChange.anim.parado;
			}
			else if ( OldChange.currentAnim== OldChange.anim.ParouBaixo)
			{			     
				 mySprite.ShowFrame(27);
			     OldChange.currentAnim = OldChange.anim.parado;			
			}
		
	}
}
