using UnityEngine;
using System.Collections;
using System.Text;

public class Boy_TesteMovimento : MonoBehaviour
{
	private Animator animacao;
	int passos = 0;
	int direcao = 0;
	bool moverParaDireita = true;
	private Vector3 posicaoInicial, posicaoDireita, posicaoEsquerda;


	// Use this for initialization
	void Start()
	{
		animacao = this.GetComponent<Animator>();      
        posicaoInicial = this.transform.position;
        posicaoDireita = this.transform.position;
        posicaoEsquerda = this.transform.position;
        posicaoDireita.x = posicaoInicial.x + 1.4f;

        posicaoEsquerda.x = posicaoEsquerda.x - 1.4f;

    }

	void Update(){

        if (moverParaDireita)
        {
            if (Vector3.Distance(this.transform.position, posicaoDireita) > 0.1f)
            {
                float step = 0.8f * Time.deltaTime;
                this.transform.position = Vector3.MoveTowards(this.transform.position, posicaoDireita, step);
            }
            else
            {
                moverParaDireita = false;
                animacao.Play("BoyEsquerda");
            }
        } else
        {
            if (Vector3.Distance(this.transform.position, posicaoEsquerda) > 0.1f)
            {
                float step = 0.8f * Time.deltaTime;
                this.transform.position = Vector3.MoveTowards(this.transform.position, posicaoEsquerda, step);
            }
            else
            {
                moverParaDireita = true;
                animacao.Play("BoyDireita");
            }
        }

    }

}