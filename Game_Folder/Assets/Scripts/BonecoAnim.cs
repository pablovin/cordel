using UnityEngine;
using System.Collections;

public class BonecoAnim : MonoBehaviour {

	// Use this for initialization
	OTAnimatingSprite mySprite;
	
	void Start () {
	
		
		mySprite = GameObject.Find("PLAYER").GetComponent<OTAnimatingSprite>();
	}
	
	// Update is called once per frame
	void Update () {
			
			if(BonecoChange.currentAnim== BonecoChange.anim.comecoAndarDireita)
			{
				mySprite.Play("right");
		        BonecoChange.currentAnim = BonecoChange.anim.andandoDireita;
			}
			
			else if ( BonecoChange.currentAnim== BonecoChange.anim.comecoAndarEsquerda)
			{
				mySprite.Play("left");
			        BonecoChange.currentAnim = BonecoChange.anim.andandoEsquerda;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.comecoAndarCima)
			{
				mySprite.Play("up");
			        BonecoChange.currentAnim = BonecoChange.anim.andandoCima;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.comecoAndarBaixo)
			{
				mySprite.Play("down");
			        BonecoChange.currentAnim = BonecoChange.anim.andandoBaixo;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.ParouDireita)
			{			    
				mySprite.ShowFrame(9);
			        BonecoChange.currentAnim = BonecoChange.anim.parado;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.ParouEsquerda)
			{			    
				 mySprite.ShowFrame(0);
			     BonecoChange.currentAnim = BonecoChange.anim.parado;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.ParouCima)
			{			    
				mySprite.ShowFrame(18);
			        BonecoChange.currentAnim = BonecoChange.anim.parado;
			}
			else if ( BonecoChange.currentAnim== BonecoChange.anim.ParouBaixo)
			{			     
				 mySprite.ShowFrame(27);
			     BonecoChange.currentAnim = BonecoChange.anim.parado;
			}
		
			
		
										
	}
}
