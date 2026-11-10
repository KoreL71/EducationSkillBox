using UnityEngine;

public class ComeBackToMenu : MonoBehaviour
{
    private PlayerInput inputs;
    public GameObject pausePanel;
    public GameObject gamePanel;
    private bool isExitGamePanel;
    private void Start()
    {
        if (inputs == null)
        {
            inputs=new PlayerInput();
            inputs.UI.Enable();
            inputs.Player.Disable();
        }
        isExitGamePanel = false;
    }
    private void Update()
    {
        ListenUserInput();
        if (isExitGamePanel == true)
        {
            gamePanel.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
    private void ListenUserInput()
    {
        isExitGamePanel = inputs.UI.ExitClick.triggered;
    }
}
