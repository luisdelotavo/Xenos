using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    public HealthBarController healthbar;
    public GameObject DeathScreen;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        { 
        if (healthbar)
        {
        healthbar.onTakeDamage(10);
        }
}
}

    void Update()
    {
        if (healthbar.health == 0)
        {
            Destroy(gameObject);
            
            

        }
    }
}
