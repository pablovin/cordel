using UnityEngine;
using System.Collections;

public class BonecoChange : MonoBehaviour {
	
	OTAnimatingSprite mySprite;
	public enum anim{ comecoAndarEsquerda, andandoEsquerda,ParouEsquerda,
					  comecoAndarDireita, andandoDireita,ParouDireita,
					  comecoAndarBaixo, andandoBaixo,ParouBaixo,
		              comecoAndarCima, andandoCima,ParouCima,
					  parado
	
	};
	
	public static anim currentAnim;
	float xAtual=0;
	float yAtual=0;
	private float moveSpeed = 5;
	bool movimentou = false;
	bool moverCamera = false;
	GameObject theCamera;
								 
	
	/* Limites da tela */
	float leftLimit = -600;
	float rightLimit = 600;
	float upLimit = 700;
	float downLimit = -700;
	
	
	public static float playerHitboxX = 0.225f; // player x = 0.45
	public static float playerHitboxY = 0.5f;
			
	void Start () {
		
		Camera.main.gameObject.GetComponent<Camera>().orthographicSize = 300;    
        mySprite = GameObject.Find("PLAYER").GetComponent<OTAnimatingSprite>();
		
		
		Debug.Log(mySprite);
		
		currentAnim = anim.parado;
		
		theCamera = Camera.main.gameObject; 
	
	}
		
	void Update () {
	
		
		moverCamera = false;
		if(Input.GetKey(KeyCode.RightArrow))
	    {       
			movimentou = true;
			yAtual = 0;
		    xAtual = 3;						
			if(currentAnim!= anim.andandoDireita)
	  		     currentAnim = anim.comecoAndarDireita;								
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
	    {       
			movimentou = true;
			yAtual = 0;
		    xAtual = -3;						
			if(currentAnim!= anim.andandoEsquerda)
	  		     currentAnim = anim.comecoAndarEsquerda;							
		}		
		else if(Input.GetKey(KeyCode.UpArrow))
	    {       
			movimentou = true;
			yAtual = 3;
		    xAtual = -2;						
			if(currentAnim!= anim.andandoCima)
	  		     currentAnim = anim.comecoAndarCima;								
		}
		else if(Input.GetKey(KeyCode.DownArrow))
	    {       
			movimentou = true;
			yAtual = -3;
		    xAtual = 2;						
			if(currentAnim!= anim.andandoBaixo)
	  		     currentAnim = anim.comecoAndarBaixo;					
			
		}
		
		if(Input.GetKeyUp(KeyCode.RightArrow))
		{			
			currentAnim = anim.ParouEsquerda;
		}
		
		else if(Input.GetKeyUp(KeyCode.LeftArrow))
		{			
			currentAnim = anim.ParouDireita;
		}
		
		else if(Input.GetKeyUp(KeyCode.UpArrow))
		{			
			currentAnim = anim.ParouCima;
		}
		
		else if(Input.GetKeyUp(KeyCode.DownArrow))
		{			
			currentAnim = anim.ParouBaixo;
		}
						
		if(Input.GetKey(KeyCode.LeftShift))
		{
			xAtual *=5;
			yAtual *=5;
		}
		
		
		
		
		
		/*
		if(currentAnim==1)
		{		
	       currentAnim = 3;			
		   mySprite.ShowFrame(0);
	
		}else if(currentAnim==2)
		{		
	       currentAnim = 4;			
		   mySprite.ShowFrame(9);
	
		}
		*/			    
			
		/*
			
		if(Input.GetKey("a"))
		{   
		   movimentou = true;
		   yAtual = 0;
		   xAtual = -3;			
		   mySprite.Play("left");
		}
		else if(Input.GetKey("d"))
		{     	 
		   movimentou = true;
		   yAtual = 0;
		   xAtual = 3;
		}
		else if(Input.GetKey("s"))
		{     	 
		   movimentou = true;
		   yAtual = -3;
		   xAtual = 0;
		}
		
					
		*/	
												
		
				
		updateMovement();	
		
		
	}
	
	
	public void updateMovement()
	{
		
										
		if(movimentou)
		{		    		
			Vector2 movement = new Vector2(xAtual*5, yAtual*5);			
			movement *= Time.deltaTime*moveSpeed;		
			
			
			if(!GetComponent<AudioSource>().isPlaying)
				GetComponent<AudioSource>().Play();			
									
						
				mySprite.position = Vector3.Lerp(mySprite.position,movement+mySprite.position,Time.time);
			
				movimentou = false;			
			
					updateCamera();
		}else
			GetComponent<AudioSource>().Stop();
	

		
	}
		
	
	public void updateCamera()
	{
		
		var vp = Camera.main.WorldToViewportPoint(mySprite.transform.position);		
		
	//	Debug.Log("SP:" + Sp);
		
		
		
		float xAtual = 0;
		float yAtual = 0;
			
			
		//Debug.Log("VP: "+vp);
		
		if(currentAnim.Equals(anim.andandoBaixo) && vp.y <=0.3)		
		{
			moverCamera = true;		
			yAtual = -5;
		}
		else if(currentAnim.Equals(anim.andandoCima) && vp.y >=0.6)		
		{
			moverCamera = true;		
			yAtual = 5;
		}
			
		
		if(currentAnim.Equals(anim.andandoDireita) && vp.x >=0.6)
		{
			moverCamera = true;
			xAtual = 5;
		}
		else if(currentAnim.Equals(anim.andandoEsquerda) && vp.x <=0.3)
		{
			moverCamera = true;
			xAtual = -5;
		}
		
			
		Vector2 movement = new Vector2(xAtual*5, yAtual*5);			
		movement *= Time.deltaTime*moveSpeed;			
					
		
		
		Vector3 novaPosicao = Vector3.Lerp(theCamera.transform.position,movement,1f);
		
					
		
			if(theCamera.transform.position.x + novaPosicao.x < leftLimit)
			    xAtual = 0;		
		
			if(theCamera.transform.position.x + novaPosicao.x > rightLimit )
			    xAtual = 0;
		
			if(theCamera.transform.position.y + novaPosicao.y < downLimit )
			    yAtual = 0;
		
			if(theCamera.transform.position.y + novaPosicao.y > upLimit )
			    yAtual = 0;
		
		
		if(moverCamera)
		{					
			
			movement = new Vector2(xAtual*5, yAtual*5);			
			movement *= Time.deltaTime*moveSpeed;	
			
		    theCamera.transform.Translate(movement);					
			
		}
	}
}
