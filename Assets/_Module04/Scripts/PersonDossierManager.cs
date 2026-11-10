using JetBrains.Annotations;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PersonDossierManager : MonoBehaviour
{
    [Header("ссылки под UI")]
    public Image IconSprite;
    public Image BaseImage;
    public TMP_Text nameText;
    public TMP_Text ageText;
    public TMP_Text originText;
    public TMP_Text callsignText;
    public TMP_Text storyGetCallsignText;
    public TMP_Text strenghtSideText;
    public TMP_Text motivationSideText;
    public  SetdataCharacter persondata;
    [Header("Данные Персон")]
    public List<PersonData> personDatas;
    
    public void SetPersonData(int index)
    {
        if (index < 0 || index > personDatas.Count)
        {
            Debug.LogWarning($"индекс {index} превысил границы ");
            return;
        }
        var _person = personDatas[index];  
        ApplyPersonData( _person );
        persondata._person= _person;
    }
    public void SetPersona(PersonData _person)
    {
        if (_person == null)
        {
            Debug.LogWarning("данные не найдены");
            return;
        }
        ApplyPersonData(_person );
        
    }
    public void ApplyPersonData(PersonData _person)
    {
        IconSprite.sprite = _person.icon;
        //nameText.text = _person.pName;
       // ageText.text = _person.age;
        originText.text = _person.origin;
        callsignText.text = _person.callsign;
        storyGetCallsignText.text = _person.StoryGetCallsign;
        strenghtSideText.text = _person.strenghtSide;
        motivationSideText.text = _person.motivationSide;
    }
    public void ResetPersonData()
    {
        IconSprite =BaseImage;
       // nameText.text = "";
        //ageText.text = "";
        originText.text = "";
        callsignText.text = "";
        storyGetCallsignText.text = "";
        strenghtSideText.text = "";
        motivationSideText.text = "";
    }
   
}
