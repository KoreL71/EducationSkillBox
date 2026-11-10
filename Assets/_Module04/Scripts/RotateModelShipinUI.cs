using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateModelShipinUI : MonoBehaviour
{
    [Header("Настройки")]
    public Transform TargetModel;//ссылка на обьект который вращается
    public float rotationSpeed =50f ;
    [Header("Переменные")]
    
    public Vector2 CurrentMousePosition;
    public bool isMiddleMouseButtonDown;
    private PlayerInput input;
    void Start()
    {
        input=new PlayerInput();
        input.UI.Enable();
        input.Player.Disable();
        CurrentMousePosition=Vector2.zero;
 
    }

   
   
    private void Update()
    {
        CheckInputUser();//считывание событий ввода игрока
        if (isMiddleMouseButtonDown==true)
        {
            if (CurrentMousePosition.x != 0)
            {
               // float rotateY = ;
                TargetModel.Rotate(0, rotationSpeed*CurrentMousePosition.x * Time.deltaTime, 0,Space.World);//применение вращения обьекта в ту или иную сторону сдвига мыши
            }
        }
        else
        {
            CurrentMousePosition = Vector2.zero;//сброс позиции мыши при отпускании пользователем средней кнопки мыши
        }
      
    }
    #region отслеживание нажатия колесика мыши и координат положения мыши 
    private void CheckInputUser()
    {
        CurrentMousePosition = input.UI.DeltaCoordinate.ReadValue<Vector2>();//привязка позиции мыши к вводу игрока
        isMiddleMouseButtonDown = input.UI.ScrollClick.IsPressed();//отслеживание зажатия кнопки мыши пользователем
    }
    #endregion
}
