using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampermetre : MonoBehaviour
{
    public GameObject Akým;
    // Start is called before the first frame update
    void Start()
    {
        Akým.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

	 public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
            Akým.SetActive(true);
		}
	}
	public void OnTriggerExit(Collider other)
	{
        if (other.gameObject.tag == "Player")
            Akým.SetActive(false);
	}

}

