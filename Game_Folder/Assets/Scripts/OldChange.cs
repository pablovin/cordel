using UnityEngine;
using System.Collections;

public class OldChange : MonoBehaviour {
	
	
	OTAnimatingSprite mySprite;
	public enum anim{ comecoAndarEsquerda, andandoEsquerda,ParouEsquerda,
					  comecoAndarDireita, andandoDireita,ParouDireita,
					  comecoAndarBaixo, andandoBaixo,ParouBaixo,
		              comecoAndarCima, andandoCima,ParouCima,
					  parado
	
	};
	
	public static anim currentAnim;					
		
	private float moveSpeed = 1;

	
	bool direcao = true;//true-Esquerda , false - Direita;
	int passos = 0;
	bool mover = true;
	
	
	// Use this for initialization
	void Start () {
		
		mySprite = GameObject.Find("Old").GetComponent<OTAnimatingSprite>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(mover)
		{
			if(passos>100)
				{
					if(direcao)
						currentAnim = anim.ParouEsquerda;
					else
						currentAnim = anim.ParouDireita;
					
					
					direcao = !direcao;	
					passos = -20;		
				
				}			
				passos++;										
							
				updateMovement();
		}
	
	}
	
	
		public void updateMovement()
		{
			
			float xAtual= 0;
			
			if(direcao)
			{
				xAtual = -3;
			if(currentAnim!= anim.andandoEsquerda)
	  		     currentAnim = anim.comecoAndarEsquerda;
				
			}else				
			{ 
				xAtual = 3;
				
			if(currentAnim!= anim.andandoDireita)
	  		     currentAnim = anim.comecoAndarDireita;
			}
									
			Vector2 movement = new Vector2(xAtual*5, 0);			
			movement *= Time.deltaTime*moveSpeed;				
								
			mySprite.position = Vector3.Lerp(mySprite.position,movement+mySprite.position,Time.time);					
			//mySprite.position += movement;	
										
			
		}				
	
		public void OnColissionEnter(Collision collision)
		{
		Debug.Log("Colidiu!");
			Dialogos.exibirOld = true;
			mover = false;	
			currentAnim = anim.andandoBaixo;
		}
	
}
