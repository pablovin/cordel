using UnityEngine;
using System.Collections;

public class BoyAnim : MonoBehaviour {
	
	
	OTAnimatingSprite mySprite;
	
	
	// Use this for initialization
	void Start () {
	mySprite = GameObject.Find("Boy").GetComponent<OTAnimatingSprite>();
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if(BoyChange.currentAnim== BoyChange.anim.comecoAndarDireita)
			{
				mySprite.Play("right");
		        BoyChange.currentAnim = BoyChange.anim.andandoDireita;
			}
			
			else if ( BoyChange.currentAnim== BoyChange.anim.comecoAndarEsquerda)
			{
				mySprite.Play("left");
			        BoyChange.currentAnim = BoyChange.anim.andandoEsquerda;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.comecoAndarCima)
			{
				mySprite.Play("up");
			        BoyChange.currentAnim = BoyChange.anim.andandoCima;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.comecoAndarBaixo)
			{
				mySprite.Play("down");
			        BoyChange.currentAnim = BoyChange.anim.andandoBaixo;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.ParouDireita)
			{			    
				mySprite.ShowFrame(9);
			        BoyChange.currentAnim = BoyChange.anim.parado;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.ParouEsquerda)
			{			    
				 mySprite.ShowFrame(0);
			     BoyChange.currentAnim = BoyChange.anim.parado;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.ParouCima)
			{			    
				mySprite.ShowFrame(18);
			        BoyChange.currentAnim = BoyChange.anim.parado;
			}
			else if ( BoyChange.currentAnim== BoyChange.anim.ParouBaixo)
			{			     
				 mySprite.ShowFrame(27);
			     BoyChange.currentAnim = BoyChange.anim.parado;			
			}
		
	}
}
