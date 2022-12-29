using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnfo : MonoBehaviour
{
    public GameObject Info;
    // Start is called before the first frame update
    void Start()
    {
        Info.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Kapat()
	{
        Info.SetActive(false);
	}
}
