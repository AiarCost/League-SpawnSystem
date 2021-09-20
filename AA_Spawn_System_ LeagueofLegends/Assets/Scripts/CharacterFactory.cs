using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : AbstractCharacterFactory
{

    private readonly ICharacterFactory _factory;
    private readonly CharacterRequirement _requirements;

    public CharacterFactory (CharacterRequirement requirements)
    {
        if (requirements.Location == "Demacia")
            _factory = (ICharacterFactory)new DemaciaFactory();
        else if (requirements.Location == "Shirima")
            _factory = new ShirimaFactory();
        else if (requirements.Location == "Shadow Isles")
        {
            Debug.Log("Before factory assignment");
            _factory = (ICharacterFactory) new ShadowIslesFactory();
            Debug.Log("After factory assignmetn");

        }
        else
            _factory = new FrejordFactory();

        _requirements = requirements;
    }


    public override ICharacter Create()
    {
        return _factory.Create(_requirements);
    }
}
