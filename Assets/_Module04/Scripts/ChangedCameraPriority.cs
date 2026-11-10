using Unity.Cinemachine;
using UnityEngine;

public class ChangedCameraPriority : MonoBehaviour
{
    public CinemachineCamera MainMenuCamera;
    public CinemachineCamera BaseMenuCamera;
    public void Start()
    {
        MainMenuCamera.Priority =1;
        BaseMenuCamera.Priority = 0;
    }
    public void OpenMainMenu()
    {
        MainMenuCamera.Priority = 1;
        BaseMenuCamera.Priority = 0;
    }
    public void OpenBaseMenu()
    {
        MainMenuCamera.Priority = 0;
        BaseMenuCamera.Priority = 1;
    }
}
