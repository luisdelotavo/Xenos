using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CharacterAttribute", menuName="Character")]
public class CharacterAttribute : ScriptableObject
{
    public string Name;
    public string Description;
    public float Speed;
    public float Strength;
    public float Health;

    public GameObject character;

    public string getSpeed()
    {
        return "Speed: " + Speed;
    }
    public string getStrength()
    {
        return "Strength: " + Strength;
    }
    public string getHealth()
    {
        return "Health: " + Health;
    }






}
