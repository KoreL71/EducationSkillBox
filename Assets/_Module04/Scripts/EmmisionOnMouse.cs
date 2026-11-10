using System.Runtime.CompilerServices;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;

public class EmmisionOnMouse : MonoBehaviour
{
    [Header("Настройки")]
    private Renderer thisPartRenderer;
    [SerializeField] private float rayDistance=100f;
    private Ray castRay;
    private RaycastHit thisCollider;
    public Color BodySelectedColor;
    public Color EngineSelectedColor;
    public Color GunsSelectedColor;
    public Color WingsSelectedColor;

    public TMP_Text PanelUpgardeName;
    private Color SelectColor;
    private Color OriginalColor;
    private MaterialPropertyBlock  modelMaterials;
    public bool isEmmesive;
    private PlayerInput input;
    private Vector2 mousePosition;
    public GameObject BasePanel;
    public GameObject UpgradePanel;
    private bool isButtonDown;
    private void Start()
    {
        if(input == null)
        {
            input=new PlayerInput();
            input.UI.Enable();
            input.Player.Disable();
            if (thisPartRenderer == null)
            {
            thisPartRenderer = GetComponent<Renderer>();
            }
            
            modelMaterials=new MaterialPropertyBlock();

        } 

    }
    private void Update()
    {
        CheckInputUser();
        castRay = Camera.main.ScreenPointToRay(mousePosition);
        if (BasePanel.activeSelf)
        {

        
        isEmmesive=Physics.Raycast(castRay,out thisCollider, rayDistance);
        Debug.DrawRay(castRay.origin,castRay.direction * 100f, Color.yellow);
      
        if (isEmmesive == true)
        {
            if(thisCollider.transform.gameObject.CompareTag("ShipBody"))
            {
                    SelectColor = BodySelectedColor;
                    thisPartRenderer=thisCollider.transform.gameObject.GetComponent<Renderer>();
                    MouseSelect(SelectColor, thisPartRenderer);
                    if (isButtonDown == true)
                    {
                        UpgradePanel.SetActive(true);
                        PanelUpgardeName.text = "Улучшение Корпуса";
                    }

                }
                    if (thisCollider.transform.gameObject.CompareTag("ShipEngine"))
                    {
                        SelectColor = EngineSelectedColor;
                        thisPartRenderer = thisCollider.transform.gameObject.GetComponent<Renderer>();
                        MouseSelect(SelectColor, thisPartRenderer);
                    if (isButtonDown == true)
                    {
                        UpgradePanel.SetActive(true);
                        PanelUpgardeName.text = "Улучшение Двигателя";
                    }

                }
                        if (thisCollider.transform.gameObject.CompareTag("ShipGuns"))
                        {
                            SelectColor = GunsSelectedColor;
                            thisPartRenderer = thisCollider.transform.gameObject.GetComponent<Renderer>();
                            MouseSelect(SelectColor, thisPartRenderer);
                    if (isButtonDown == true)
                    {
                        UpgradePanel.SetActive(true);
                        PanelUpgardeName.text = "Улучшение Орудий";
                    }

                }
                            if (thisCollider.transform.gameObject.CompareTag("ShipWings"))
                            {
                                SelectColor = WingsSelectedColor;
                                thisPartRenderer = thisCollider.transform.gameObject.GetComponent<Renderer>();
                                MouseSelect(SelectColor,thisPartRenderer);
                    if (isButtonDown == true)
                    {
                        UpgradePanel.SetActive(true);
                        PanelUpgardeName.text = "Улучшение Крыльев";
                    }

                }
                            
              
            }

            else  if (isEmmesive == false)
            {
                OutMousSelect();
            }
            

        }
    }
    #region подсветка части корабля
    private void MouseSelect(Color setColor,Renderer thisPartRenderer)
    {
        thisPartRenderer.GetPropertyBlock(modelMaterials);
        modelMaterials.SetColor("_EmissionColor",SelectColor*3f);
        thisPartRenderer.SetPropertyBlock(modelMaterials);
    }
    private void OutMousSelect()
    {
        thisPartRenderer.GetPropertyBlock(modelMaterials);
        modelMaterials.SetColor("_EmissionColor", Color.black);
        thisPartRenderer.SetPropertyBlock (modelMaterials);
    }
  
    #endregion
    #region Считывание событий ввода
    private void CheckInputUser()
    {
        mousePosition = input.UI.Point.ReadValue<Vector2>();
        isButtonDown = input.UI.Click.triggered;
    }
    #endregion
}
