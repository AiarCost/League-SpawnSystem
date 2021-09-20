using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public string Location = "Demacia";
    public string CharType = "Hero";
    public string Gender = "Male";
    public Text UItextQ;
    public Text Name;
    public Image Background;


    CharacterRequirement requirements = new CharacterRequirement();


    private ICharacter GetCharacter(CharacterRequirement requirements)
    {
        CharacterFactory factory = new CharacterFactory(requirements);
        return factory.Create();
    }


    public void LocationChange(Text location)
    {
        requirements.Location = location.text;
        Debug.Log(location.text);
    }

    public void CharTypeChange(Text characterType)
    {
        requirements.CharacterType = characterType.text;

        Debug.Log(characterType.text);
    }

    public void GenderChange(Text gender)
    {
        requirements.Gender = gender.text;
        Debug.Log(gender.text);
    }

    public void GenerateCharacterButton()
    {
        Debug.Log("Requirements: " + requirements.Location + ", " + requirements.CharacterType + ", " + requirements.Gender);

        if (requirements.Location == null)
            requirements.Location = "Demacia";
        if (requirements.CharacterType == null)
            requirements.CharacterType = "Hero";
        if (requirements.Gender == null)
            requirements.Gender = "Male";



        ICharacter character = GetCharacter(requirements);

        Debug.Log(character);

        
        character.ChangeInterface(UItextQ, Name, Background);
    }
}
