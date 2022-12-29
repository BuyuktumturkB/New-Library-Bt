using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminHareket : MonoBehaviour
{
    private float x=3;
    public GameObject player;
    public GameObject zemin;
    private float kontrolx=-12;
    private float respawn = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
            zemin.transform.Translate(Vector3.back * x * Time.deltaTime);
     

        if (Input.GetKey("a"))
		{
            player.transform.Translate(Vector3.left * 2*Time.deltaTime );
		}
        else if (Input.GetKey("d"))
		{
			player.transform.Translate(Vector3.right * 2*Time.deltaTime );

		}
        
        Konumkontrol();

    }
    void Konumkontrol()
	{
        if (zemin.transform.position.x <-8 && zemin.transform.position.x>kontrolx )
		{
            zemin.transform.position=(new Vector3(respawn,0.46f,-2.8f));
		} 
	} 
}
