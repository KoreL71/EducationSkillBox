using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowInformationCharacter : MonoBehaviour
{
    public TMP_Text showName;
    public TMP_Text showAge;
    public TMP_Text showGender;

    public TMP_Text showCallsign;
    public TMP_Text showInformation;
    public Image showIcon;
    public TMP_Text dossierName;
    public TMP_Text dossierAge;
    public CharacterData CharacterData;
    public SetdataCharacter inputData;
    private void OnEnable()
    {
        ShowDossier();
    }
    public void ShowDossier()
    {
        showName.text = CharacterData.namePlayer;
        showAge.text = CharacterData.agePlayer;
        if (CharacterData.isMale == true)
        {
            showGender.text = "мужской";
        }
        if (CharacterData.isMale == false)
        {
            showGender.text = "Женский";
        }
         showCallsign.text=CharacterData.callsignPlayer;
        showIcon.sprite= CharacterData.iconPlayer;
        showInformation.text = $"Родился: {CharacterData.originPlayer},\n Сильная сторона: {CharacterData.strenghtsidePlayer},\n Мотивация: {CharacterData.motivationsidePlayer}";
        
    }
    public void ShowNameAge()
    {
        dossierName.text = inputData.namePerson.text;
        dossierAge.text = inputData.agePerson.text;
    }
    
}
