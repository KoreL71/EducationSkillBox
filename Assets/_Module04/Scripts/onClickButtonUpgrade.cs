using TMPro;
using UnityEngine;

public class onClickButtonUpgrade : MonoBehaviour
{
    public GameObject WarningTextUpgradePanel;
     private float timerShow;
    public void OnClickButtonUpgrade()
    {
        WarningTextUpgradePanel.gameObject.SetActive(true);
        timerShow = 1.5f;
    }
    private void Update()
    {
        if (timerShow > 0 && WarningTextUpgradePanel.gameObject.activeSelf)
        {
            timerShow -= Time.deltaTime;
        }
        else if (timerShow <= 0)
        {
            timerShow = -10f;
            WarningTextUpgradePanel.gameObject.SetActive(false);
        }


    }
}
