using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;
    private Vector3 angset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
        
    }
	private void LateUpdate()
	{
        transform.position = Player.transform.position+offset;
        
	}
	// Update is called once per frame
}
