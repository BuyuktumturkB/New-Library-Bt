using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneManager : MonoBehaviour
{
	public GameObject clone;
	private GameObject Aclone;
	
	// Start is called before the first frame update


	// Update is called once per frame
	public void Update()
    {
		CoppyandDelete();
	}
	void CoppyandDelete()

	{
		float clonex = clone.transform.position.x +2f;
		float clonez = clone.transform.position.z + 1f;
		float cloney = 0;
		
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
