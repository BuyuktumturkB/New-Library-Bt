using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public GameObject [] Engeller;
    private float SSpawntime=0;
    private float x;
    private float y;
    private float z;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* SSpawntime = Time.deltaTime;
        if (SSpawntime <= 0)
		{
            Spawn();
            x = Random.Range(0f, 10f);
            y = 0f;
            z = Random.Range(-9f, 4f);

            
            SSpawntime =(Random.Range(-2f, 2f));
		} */
		
       
    }
    public void Seviyeli()
	{
        SceneManager.LoadScene("Level1");
	}
    public void Cikis()
	{
        Application.Quit();
	}
    public void Rekabetci()
	{

	}
    public void Spawn()
	{
        int randomIndex = Random.Range(0, Engeller.Length);
        Instantiate(Engeller[randomIndex], new Vector3(x, y, z), Quaternion.identity);

    }
}
