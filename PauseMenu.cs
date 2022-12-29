using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	float menucounter = 0;
	public GameObject Pause;
	public GameObject Secim;
	
	void Start()
	{
		Pause.SetActive(false);
		Secim.SetActive(false);
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("escape") && menucounter == 0)
		{
			Pause.SetActive(true);
			menucounter++;
		}
		else if (Input.GetKeyDown("escape") && menucounter == 1)
		{
			Pause.SetActive(false);
			menucounter = 0;
		}
	}

	public void DevamEt()
	{
		Pause.SetActive(false);
	}
	public void Cýkýs()
	{
		Application.Quit();
	}
	public void Anamenü()
	{
		SceneManager.LoadScene("AnaMenü");
	}
	public void SahneDegiþimi()
	{
		Secim.SetActive(true);
		Pause.SetActive(false);

	}

	public void Geri()
	{
		Secim.SetActive(false);
		Pause.SetActive(true);

	}
	public void level1()
	{
		SceneManager.LoadScene("Level1");
	}
	public void Level2()
	{
		SceneManager.LoadScene("Level2");
	}
	public void Level3()
	{
		SceneManager.LoadScene("Level3");
	}
	public void Level4()
	{
		SceneManager.LoadScene("Level4");
	}
	public void Level5()
	{
		SceneManager.LoadScene("Level5");
	}
	

}
