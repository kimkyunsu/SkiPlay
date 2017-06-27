using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float jumpPower = 5f;
	private bool grounded = true;
	private float acc = 1f;
	private float mySpeed = 0f;

	Rigidbody rigdbody;
	bool isJumping;




	void Awake()
	{
		rigdbody = GetComponent<Rigidbody> ();
	}


	void Start()
	{
		
	}




	void Update()
	{

		transform.Translate (Input.acceleration.x, 0, -Input.acceleration.z);
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*10f, 0, 0); 
		transform.Translate(0, 0, Input.GetAxis("Vertical")*Time.deltaTime*10f); 


		if (Input.GetKey (KeyCode.Space))
			isJumping = true;

	}












}