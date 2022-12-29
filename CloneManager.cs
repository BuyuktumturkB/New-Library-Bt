using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneManager : MonoBehaviour
{
	public GameObject clone;
	private GameObject Aclone;
	public float clonez;
	public float clonex;
	public float cloney;

	// Start is called before the first frame update


	// Update is called once per frame
	public void Update()
    {
		CoppyandDelete();
	}
	void CoppyandDelete()

	{
		
		
		if (Input.GetKeyDown("c") )
		{
			clone.SetActive(true);
			Aclone = Instantiate(clone,new Vector3(clonex,cloney,clonez) , Quaternion.identity);

		}
		else if (Input.GetKeyDown("e"))
		{
			Destroy(Aclone);

		}
	}
}
