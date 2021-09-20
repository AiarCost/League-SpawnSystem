using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationFactory : MonoBehaviour { }


public class DemaciaFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirement requirements)
    {
        if(requirements.CharacterType == "Hero")
        {
            if (requirements.Gender == "Male")
                return new Garen();
            else
                return new Lux();
        }
        else if(requirements.CharacterType == "Villian")
        {
            if (requirements.Gender == "Male")
                return new Sylas();
            else
                return new Morgana();
        }
        else
        {
            if (requirements.Gender == "Male")
                return new Lucian();
            else
                return new Sona();
        }
    }
}

public class ShirimaFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirement requirements)
    {
        if (requirements.CharacterType == "Hero")
        {
            if (requirements.Gender == "Male")
                return new Azir();
            else
                return new Kaisa();
        }
        else if (requirements.CharacterType == "Villian")
        {
            if (requirements.Gender == "Male")
                return new Xerath();
            else
                return new Cassiopeia();
        }
        else
        {
            if (requirements.Gender == "Male")
                return new Rammus();
            else
                return new Sivir();
        }
    }
}

public class FrejordFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirement requirements)
    {
        if (requirements.CharacterType == "Hero")
        {
            if (requirements.Gender == "Male")
                return new Braum();
            else
                return new Ashe();
        }
        else if (requirements.CharacterType == "Villian")
        {
            if (requirements.Gender == "Male")
                return new Trundle();
            else
                return new Lissandra();
        }
        else
        {
            if (requirements.Gender == "Male")
                return new Nunu_Willump();
            else
                return new Sejuani();
        }
    }
}

public class ShadowIslesFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirement requirements)
    {
        Debug.Log("Character creation: " + requirements.CharacterType);
        if (requirements.CharacterType == "Hero")
        {
            if (requirements.Gender == "Male")
                return new Yorick();
            else
                return new Senna();
        }
        else if (requirements.CharacterType == "Villian")
        {
            if (requirements.Gender == "Male")
                return new Thresh();
            else
                return new Vex();
        }
        else
        {
            if (requirements.Gender == "Male")
                return new Hecarim();
            else
                return new Kalista();
        }
    }
}
