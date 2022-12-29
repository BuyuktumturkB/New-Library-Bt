using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody Rbd;
	 float yatay;
	 float dikey;
	public GameObject Player;
	
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
		else if (other.gameObject.tag == "Resistor2")
		{
			velocity=velocity/10;
		}

	}
		 void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Resistor")
		{
			velocity = 2f;

		}
		else if (other.gameObject.tag == "Resistor2")
		{
			velocity = 2f;
		}

	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Volt")
		{
			Destroy(Player);
		}
	}

}




