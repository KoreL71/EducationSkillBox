using System.Collections.Generic;
using UnityEngine;

public class UIScreenManager : MonoBehaviour
{
    [Header("панели интерфейса")]
    #region игровые обьекты - панели UI интерфейса

    [SerializeField] private GameObject AuthorsPanel;
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private GameObject mainMenu;
    [SerializeField]  private GameObject settingsPanel;
    [SerializeField]  private GameObject playerProfilePanel;
    [SerializeField]  private GameObject settingsPlayerProfilePanel;
    [SerializeField] private GameObject personalInformationPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject changeLevelPanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject lossPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject baseMenuPanel;
     #endregion
    private Dictionary <string,GameObject> _panels=new Dictionary<string,GameObject>();
    private void Start()
    {
        //открываем доступ к панелям меню по имени через заполнение словаря
        if (AuthorsPanel != null) _panels["PanelAuthors"] = AuthorsPanel;
        if (StartPanel != null) _panels["PanelStart"]=StartPanel;
        if (mainMenu != null) _panels["MainMenu"] = mainMenu;
        if (settingsPanel != null) _panels["SettingsPanel"] = settingsPanel;
        if (playerProfilePanel != null) _panels["PlayerProfilePanel"] = playerProfilePanel;
        if (settingsPlayerProfilePanel != null) _panels["SettingsPlayerProfilePanel"] = settingsPlayerProfilePanel;
        if (personalInformationPanel != null) _panels["PanelPersonInformation"] = personalInformationPanel;
        if (pausePanel != null) _panels["PausePanel"] = pausePanel;
        if (changeLevelPanel != null) _panels["ChangeLevelPanel"] = changeLevelPanel;
        if (winPanel != null) _panels["WinPanel"] = winPanel;
        if (lossPanel != null) _panels["LossPanel"] = lossPanel;
        if (gamePanel != null) _panels["GamePanel"] = gamePanel;
        if (baseMenuPanel != null) _panels["PanelBase"] = baseMenuPanel;
    }
    private void SelectScreen(string screenName)
    {
        foreach (var panel  in _panels)
        {
            if (panel.Value != null)
            {
                panel.Value.gameObject.SetActive(false);
            }
        }
        if(_panels.TryGetValue(screenName,out GameObject selectScreen))
        {
            selectScreen.SetActive(true);
        }
        else
        {
            Debug.Log($"экран {screenName} не найден ");
        }
    }
    public void ShowPanelAuthors() => SelectScreen("PanelAuthors");
    public void ShowScreenStartPanel() => SelectScreen("PanelStart");
    public void ShowScreenMainMenu() => SelectScreen("MainMenu");
    public void ShowScreenSettingsPanel() => SelectScreen("SettingsPanel");
    public void ShowScreenPlayerProfilePanel() => SelectScreen("PlayerProfilePanel");
    public void ShowScreenSettingsPlayerProfilePanel() => SelectScreen("SettingsPlayerProfilePanel");
    public void ShowScreenPanelPersonInformation() => SelectScreen("PanelPersonInformation");
    public void ShowScreenPausePanel() => SelectScreen("PausePanel");
    public void ShowScreenchangeLevelPanel() => SelectScreen("ChangeLevelPanel");
    public void ShowScreenWinPanel() => SelectScreen("WinPanel");
    public void ShowScreenLossPanel() => SelectScreen("LossPanel");
    public void ShowScreenGamePanel() => SelectScreen("GamePanel");
    public void ShowScreenPanelBase() => SelectScreen("PanelBase");

    
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}
