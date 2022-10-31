using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;
    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Character.GetComponent<CollisionController>().healthbar.health == 0)
        {
            Invoke("Death", 0.1f);
        }
        
    }
    void Death()
    {
        deathScreen.SetActive(true);
        Invoke("Restart", 4f);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        deathScreen.SetActive(false);
    }
}
