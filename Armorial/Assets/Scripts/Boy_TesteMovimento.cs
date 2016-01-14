using UnityEngine;
using System.Collections;
using System.Text;

public class Boy_TesteMovimento : MonoBehaviour
{
	private Animator animacao;
	int passos = 0;
	int direcao = 0;
	bool mover = true;
	private Transform posicaoInicial, posicaoFinal;

	// Use this for initialization
	void Start()
	{
		animacao = this.GetComponent<Animator>();
		animacao.Play ("BoyDireita");
		posicaoInicial.TransformVector(transform.position.x, transform.position.y, transform.position.z);
		posicaoFinal.TransformVector(transform.position.x-1, transform.position.y-1, transform.position.z);
	}

	void Update(){
		if (mover) 
			if (passos == 10) {
			direcao = -1;
			animacao.SetBool ("Esquerda", false);
		//	animacao.transform.position = Vector3.MoveTowards (posicaoInicial.position, posicaoFinal.position, 20);
			}
		else if(passos == 0){
			direcao = 1;
			animacao.SetBool ("Esquerda", true);
		//	animacao.transform.position = Vector3.MoveTowards (posicaoFinal.position, posicaoInicial.position, 20);
		}
		passos = passos + direcao;

		Debug.Log (passos);
	//	animacao.SetBool ("Esquerda", false);

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