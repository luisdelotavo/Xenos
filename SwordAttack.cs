using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordAttack : MonoBehaviour
{
    CharacterController controller;
    Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public float lightAttackS = 1f;
    public float heavyAttackS = 8.5f;
    public float lightAttackA = 1.5f;
    public float heavyAttackA = 15f;
    public float lightAttackN = 0.5f;
    public float heavyAttackN = 3f;
    public LayerMask enemyLayers;
    public GameObject characterScripts;
    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        //Checks if Character 1 "Knight" is loaded and loads attack animations for him
        if (SceneManager.GetActiveScene().name == "Playground" || SceneManager.GetActiveScene().name == "Map1Hero")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                anim.SetTrigger("Attack1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackS);
                }

            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("Attack2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackS);
                }
            }
        }
        //Checks if Character 2 "Ragnarok" is loaded and loads attack animations for him
        else if (SceneManager.GetActiveScene().name == "PlaygroundTwo" || SceneManager.GetActiveScene().name == "Map2Hero")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                anim.SetTrigger("axeA1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackA);
                }

            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("axeA2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackA);
                }
            }
        }

        //Checks if Character 3 "Ninja" is loaded and loads attack animations for him
        else if (SceneManager.GetActiveScene().name == "PlaygroundThree" || SceneManager.GetActiveScene().name == "Map3Hero")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                anim.SetTrigger("punchA1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackN);
                }

            }

            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("punchA2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackN);
                }
            }
        }



    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}