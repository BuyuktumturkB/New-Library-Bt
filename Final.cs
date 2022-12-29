using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject tebrik;
    // Start is called before the first frame update
    void Start()
    {
        tebrik.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter(Collision obje)
	{
        if (obje.gameObject.tag == "Player")
            tebrik.SetActive(true);
        
	}

}
