using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetdataCharacter : MonoBehaviour
{
    public TMP_InputField namePerson;
    public TMP_InputField agePerson;
    public Toggle Male, Female;
    private TMP_Sprite iconPerson;

    private TMP_Text originPerson;
    private TMP_Text callsignPerson;
    private TMP_Text storygetcallsignPerson;
    private TMP_Text strenghtsidePerson;
    private TMP_Text motivationsidePerson;

    public Slider Music, SoundEffect;

    public PersonData _person;
    public CharacterData currentPerson;

  
    public void OnConfirmButtonPress()
    {
        string name = namePerson.text;
        string age= agePerson.text;
        if (Male.isOn == true)
        {
            currentPerson.isMale = Male.isOn;
        }
        else
        {
            currentPerson.isMale= false;
        }
        currentPerson.namePlayer = name;
        currentPerson.agePlayer = age;
        currentPerson.originPlayer = _person.origin;
        currentPerson.iconPlayer = _person.icon;
        currentPerson.callsignPlayer = _person.callsign;
        currentPerson.storygetcallsignPlayer = _person.StoryGetCallsign;
        currentPerson.strenghtsidePlayer = _person.strenghtSide;
        currentPerson.motivationsidePlayer = _person.motivationSide;
        Session.SetCharacter(currentPerson);
    }
    public void SetLevelSoud()
    {
        float levelMusic = Music.value;
        float levelSoundEffect = SoundEffect.value;
        currentPerson.levelMusic = levelMusic;
        currentPerson.levelSoundEffect = levelSoundEffect;
        Session.SetCharacter(currentPerson);
    }
}
