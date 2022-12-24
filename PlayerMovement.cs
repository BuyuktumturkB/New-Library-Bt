using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody Rbd;
	 float yatay;
	 float dikey;
	
	public GameObject resistor;
	




	public float velocity = 2f;
	// Start is called before the first frame update
	void Start()
	{
		Rbd = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		yatay = Input.GetAxisRaw("Vertical");
		dikey = Input.GetAxisRaw("Horizontal");
		Vector3 mov = new Vector3(yatay, 0, dikey);


		Rbd.AddForce(mov * velocity );
		




	}
	 void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Resistor")
		{
			velocity = velocity / 4;
			
		}

	}
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Resistor")
		{
			velocity = 2f;

		}
	}

}




