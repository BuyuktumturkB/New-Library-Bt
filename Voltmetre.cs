using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltmetre : MonoBehaviour
{
    public GameObject Player;
    public GameObject patlama;
    public GameObject Vletter;
    public float x;
    public float z;
    public float y;
    public GameObject OyunBitti;
    
    // Start is called before the first frame update
    void Start()
    {
        OyunBitti.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OyunBitti.SetActive(true);
            IsGameOver();
            
           
        }
    }
    public void TekrarDene()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    void IsGameOver()
	{

        Player.SetActive(false);
        Vletter.SetActive(false);

        Instantiate(patlama, new Vector3(x, y, z), transform.rotation);

        
        
    }
}
		

   

	

