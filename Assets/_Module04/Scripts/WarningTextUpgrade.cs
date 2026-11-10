using TMPro;
using UnityEngine;

public class WarningTextUpgrade : MonoBehaviour
{
    public GameObject WarningPanel;
    public float timerShow;
    public void OnClickButtonUpgrade()
    {
        WarningPanel.SetActive(true);
        timerShow = 1.5f;
    }
    private void Update()
    {
        if (timerShow > 0 && WarningPanel.activeSelf)
        {
            timerShow -= Time.deltaTime;
        }
        else if (timerShow <= 0)
        {
            timerShow = -10f;
            WarningPanel.SetActive(false);
        }


    }
}
