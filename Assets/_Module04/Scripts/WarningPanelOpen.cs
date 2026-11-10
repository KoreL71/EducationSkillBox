using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WarningPanelOpen : MonoBehaviour
{
    
    public GameObject warningPanel;
    public TMP_Dropdown LanguageDropDown;

    
    private int languageDropDownValue;

    void Start()
    {
        languageDropDownValue = LanguageDropDown.value;
        LanguageDropDown.onValueChanged.AddListener(ClickVariants);
    }
    public void ClickVariants(int Value)
    {
        warningPanel.SetActive(true);
    }
    public void ChangeRussianLanguage()
    {
        LanguageDropDown.value = languageDropDownValue;
        LanguageDropDown.RefreshShownValue();
        warningPanel.SetActive(false);
    }
}
