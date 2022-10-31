using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
        }






    }
