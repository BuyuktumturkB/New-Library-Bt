using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
	public GameObject Cam1;
	public GameObject Cam2;
	float camcounter=0;

	// pStart is called before the first frame update
	void Start()
	{
		Cam1.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("space") && camcounter==1)
		{
			Cam2.SetActive(false);
			Cam1.SetActive(true);
			camcounter = 0;
		}
		else if (Input.GetKeyDown("space") && camcounter == 0)
		{
			Cam1.SetActive(false);
			Cam2.SetActive(true);
			camcounter++;
		}

	}
}
