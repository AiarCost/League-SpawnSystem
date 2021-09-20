using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface ICharacter {

    public void ChangeInterface(Text quote, Text Name, Image Background);
}


//Demacian Characters
public class Garen : ICharacter {

    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "DEMACIA!";
        Name.text = "Garen";
        Sprite LoadSprite = Resources.Load<Sprite>("Garen");
        Background.sprite = LoadSprite;
    }
};
public class Lux : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Let's light it up!";
        Name.text = "Lux";
        Background.sprite = Resources.Load<Sprite>("Lux");
    }
};
public class Sylas : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "No more kings! No more queens! No more mage-seekers! It all ends now!";
        Name.text = "Sylas";
        Background.sprite = Resources.Load<Sprite>("Sylas");
    }
};
public class Morgana : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Wings bound and feet earthly tethered, I move against the false promises of order and justice.";
        Name.text = "Morgana";
        Background.sprite = Resources.Load<Sprite>("Morgana");
    }
};
public class Lucian : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Everybody dies. Some just need a little help.";
        Name.text = "Lucian";
        Background.sprite = Resources.Load<Sprite>("Lucian");
    }
};
public class Sona : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "A wrong note is just...a happy little accident.";
        Name.text = "Sona";
        Background.sprite = Resources.Load<Sprite>("Sona");
    }
};


//Shiriman Characters
public class Azir : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Shurima will once again stretch to the horizon.";
        Name.text = "Azir";
        Background.sprite = Resources.Load<Sprite>("Azir");
    }
};
public class Kaisa : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "I can rid them of these monsters, but who will save them from themselves?";
        Name.text = "Kai'sa";
        Background.sprite = Resources.Load<Sprite>("Kaisa");
    }
};
public class Xerath : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "The world may crumble, but I shall remain.";
        Name.text = "Xerath";
        Background.sprite = Resources.Load<Sprite>("Xerath");
    }
};
public class Cassiopeia : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Keep your enemies close… and me closer.";
        Name.text = "Cassiopeia";
        Background.sprite = Resources.Load<Sprite>("Cassiopeia");
    }
};
public class Rammus : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Ok";
        Name.text = "Rammus";
        Background.sprite = Resources.Load<Sprite>("Rammus");
    }
};
public class Sivir : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "I always take my toll - blood, or gold.";
        Name.text = "Sivir";
        Background.sprite = Resources.Load<Sprite>("Sivir");
    }
};


//Freljord
public class Braum : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "If you have problem, you come to me first.";
        Name.text = "Braum";
        Background.sprite = Resources.Load<Sprite>("Braum");
    }
};
public class Ashe : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Avarosan is the tribe of many, because all Freljordians are one people";
        Name.text = "Ashe";
        Background.sprite = Resources.Load<Sprite>("Ashe");
    }
};
public class Trundle : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "I'm troll judge, troll jury, and execu... troll!";
        Name.text = "Trundle";
        Background.sprite = Resources.Load<Sprite>("Trundle");
    }
};
public class Lissandra : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "The world began in ice and it will end in ice.";
        Name.text = "Lissandra";
        Background.sprite = Resources.Load<Sprite>("Lissandra");
    }
};
public class Nunu_Willump : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "This way to... Adventure!";
        Name.text = "Nunu & Willump";
        Background.sprite = Resources.Load<Sprite>("Nunu");
    }
};
public class Sejuani : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "The cold does not forgive.";
        Name.text = "Sejuani";
        Background.sprite = Resources.Load<Sprite>("Sejuani");
    }
};


//Shadow Isles
public class Yorick : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "This land will never heal. But I will lay it to rest.";
        Name.text = "Yorick";
        Background.sprite = Resources.Load<Sprite>("Yorick");
    }
};
public class Senna : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "The mist knows my name. It howled it for years, but it was only asking for help.";
        Name.text = "Senna";
        Background.sprite = Resources.Load<Sprite>("Senna");
    }
};
public class Thresh : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Screaming won't do you any good, but it's music to my ears.";
        Name.text = "Thresh";
        Background.sprite = Resources.Load<Sprite>("Thresh");
    }
};
public class Vex : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Spreading misery is what brings me joy. I mean... brings me misery. I mean... joyous misery?";
        Name.text = "Vex";
        Background.sprite = Resources.Load<Sprite>("Vex");
    }
};
public class Hecarim : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Behold, the might of the Shadow Isles.";
        Name.text = "Hecarim";
        Background.sprite = Resources.Load<Sprite>("Hecarim");
    }
};
public class Kalista : ICharacter {
    public void ChangeInterface(Text quote, Text Name, Image Background)
    {
        quote.text = "Turncoats, oath breakers and betrayers... we hate them all.";
        Name.text = "Kalista";
        Background.sprite = Resources.Load<Sprite>("Kalista");
    }
};



public interface ICharacterFactory
{
    ICharacter Create(CharacterRequirement requirements);
}
