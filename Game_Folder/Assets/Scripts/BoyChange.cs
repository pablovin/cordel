using System;
using UnityEngine;
using System.Collections;



	public class BoyChange: MonoBehaviour
	{
		
		
		OTAnimatingSprite mySprite;
	public enum anim{ comecoAndarEsquerda, andandoEsquerda,ParouEsquerda,
					  comecoAndarDireita, andandoDireita,ParouDireita,
					  comecoAndarBaixo, andandoBaixo,ParouBaixo,
		              comecoAndarCima, andandoCima,ParouCima,
					  parado
	
	};
	
	public static anim currentAnim;
		
				
		
		private float moveSpeed = 5;
	
		
		bool direcao = true;//true-Esquerda , false - Direita;
		int passos = 0;
		bool fimMovimento = false;
		bool mover = true;
		
		void Start () {
				
        mySprite = GameObject.Find("Boy").GetComponent<OTAnimatingSprite>();
				
		Debug.Log(mySprite);
						
	
	}
			
		
		void Update()
		{
			
		
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
	
		void OnTriggerEnter(Collider otherObj)
		{
			Debug.Log("Colidiu!");
			Dialogos.exibirBoy = true;
			mover = false;	
			currentAnim = anim.andandoBaixo;
		}
	
	
	
		
	}


