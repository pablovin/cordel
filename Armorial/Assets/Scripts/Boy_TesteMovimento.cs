using UnityEngine;
using System.Collections;

public class Boy_TesteMovimento : MonoBehaviour
{
	private Animator animacao;
	bool direcao = true;//true-Esquerda , false - Direita;
	int passos = 1;
	bool mover = true;

	// Use this for initialization
	void Start()
	{
		animacao = this.GetComponent<Animator>();
		animacao.Play ("BoyCima");
	}

	void Update(){
//		if (mover) {
//			if (passos > 0 && passos <= 10) {
//				passos++;
//				animacao.SetTarget (animacao.avatar.GetType, 1);
//			}
//
//		}
		animacao.SetInteger ("Direcao", 2);

	}

//
//	// Update is called once per frame
//	void Update()
//	{
//
//
//		if(mover)
//		{
//			if(passos>100)
//			{
//				if(direcao)
//					currentAnim = anim.ParouEsquerda;
//				else
//					currentAnim = anim.ParouDireita;
//
//
//				direcao = !direcao;	
//				passos = -20;		
//
//			}			
//			passos++;										
//
//			updateMovement();
//		}
//
//	}
//
//
//
//	public void updateMovement()
//	{
//
//		float xAtual= 0;
//
//		if(direcao)
//		{
//			xAtual = -3;
//			if(currentAnim!= anim.andandoEsquerda)
//				currentAnim = anim.comecoAndarEsquerda;
//
//		}else				
//		{ 
//			xAtual = 3;
//
//			if(currentAnim!= anim.andandoDireita)
//				currentAnim = anim.comecoAndarDireita;
//		}
//
//		Vector2 movement = new Vector2(xAtual*5, 0);			
//		movement *= Time.deltaTime*moveSpeed;				
//
//		mySprite.position = Vector3.Lerp(mySprite.position,movement+mySprite.position,Time.time);					
//		//mySprite.position += movement;	
//
//
//	}		
}