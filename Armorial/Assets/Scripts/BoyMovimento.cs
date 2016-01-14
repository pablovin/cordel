using UnityEngine;
using System.Collections;

public class BoyMovimento : MonoBehaviour
{

	private Animator animator;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{

		var vertical = Input.GetAxis("Vertical");
		var horizontal = Input.GetAxis("Horizontal");

//		if (vertical > 0)
//		{
//			animator.SetInteger("Direcao", 2);
//		}
//		else if (vertical < 0)
//		{
//			animator.SetInteger("Direcao", 0);
//		}
		if (horizontal < 0)
		{
			animator.SetBool("Esquerda", true);
		}
		else if (horizontal > 0)
		{
			animator.SetBool("Esquerda", false);
		}
	}
}