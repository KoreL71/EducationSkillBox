
using UnityEngine;
using UnityEngine.Windows;

public class ClickShipOpenBase : MonoBehaviour
{
    private Ray mouseRay;
    private float rayLength =200f;
    private Vector2 mousePosition;
    public ChangedCameraPriority CameraPriority;
    private bool isSelect,onClickButtonMouse;
    public  GameObject BasePanel,MainMenu;
    private PlayerInput input;
    private RaycastHit hitObject;
    void Start()
    {
        if (input == null)
        {
            input = new PlayerInput();
            input.UI.Enable();
            input.Player.Disable();
        }
        if (BasePanel.activeSelf == true)
        {
            BasePanel.SetActive(false);
        }
    }
    void Update()
    {
        CheckUserInput();
        mouseRay=Camera.main.ScreenPointToRay(mousePosition);
        isSelect=Physics.Raycast(mouseRay,rayLength);
        if (isSelect && MainMenu.activeSelf == true)
        {
            Debug.Log("попадание");
            if (onClickButtonMouse == true)
            {
                CameraPriority.OpenBaseMenu();
                MainMenu.SetActive(false);
                BasePanel.SetActive(true);
            }
          
        }
    }
    #region Считывание ввода игрока
    private void CheckUserInput()
    {
        mousePosition = input.UI.Point.ReadValue<Vector2>();
        onClickButtonMouse = input.UI.RightClick.IsPressed();
    }
    #endregion
}
