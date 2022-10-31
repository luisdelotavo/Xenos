using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CharSelect : MonoBehaviour
{
    public CharacterAttribute[] charModels;
    public Transform spot;
    public TextMeshProUGUI title;
    public TextMeshProUGUI health;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI description;

    private List<GameObject> characters;
    private int currentChar;

    private void Awake()
    {
        title = title.GetComponent<TextMeshProUGUI>();
        health = health.GetComponent<TextMeshProUGUI>();
        speed = speed.GetComponent<TextMeshProUGUI>();
        strength = strength.GetComponent<TextMeshProUGUI>();
        description = description.GetComponent<TextMeshProUGUI>();
    }



    // Start is called before the first frame update
    void Start()
    {
        characters = new List<GameObject>();

        foreach (var charModel in charModels)
                {
            GameObject go = Instantiate(charModel.character, spot.position, Quaternion.identity);
            go.SetActive(false);
            go.transform.SetParent(spot);
            characters.Add(go);
            go.transform.Rotate(0.0f, -90.0f, 0.0f);
            go.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        }
        ShowCharFromList();
    }

    void ShowCharFromList()
    {
        characters[currentChar].SetActive(true);
        title.text = charModels[currentChar].Name;
        health.text = charModels[(currentChar)].getHealth();
        speed.text = charModels[currentChar].getSpeed();
        strength.text = charModels[currentChar].getStrength();
        description.text = charModels[currentChar].Description;
    }

    public void onClickNext()
    {
        characters[currentChar].SetActive(false);
        if (currentChar < characters.Count - 1)
            ++currentChar;
        else
            currentChar = 0;

        ShowCharFromList();
    }

    public void onClickPrev()
    {
        characters[currentChar].SetActive(false);

        if (currentChar == 0)
            currentChar = characters.Count - 1;
        else
            --currentChar;

        ShowCharFromList();
    }

    public void confirmClick()
    {
        if(currentChar == 0){
            SceneManager.LoadScene("Playground");
        }
        else if(currentChar == 1){
            SceneManager.LoadScene("PlaygroundTwo");
        }
        else if(currentChar == 2){
            SceneManager.LoadScene("PlaygroundThree");
        }
            
    }

}
