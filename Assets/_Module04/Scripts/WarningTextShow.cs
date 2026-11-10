using TMPro;
using UnityEngine;
public class WarningTextShow : MonoBehaviour
{
    public TMP_Text WarningText;
    public float timerShow;
    public void OnClickButtonLevel()
    {
        WarningText.gameObject.SetActive(true);
        timerShow = 1.5f;
    }
    private void Update()
    {
        if (timerShow > 0&&WarningText.gameObject.activeSelf)
        {
            timerShow-= Time.deltaTime;
        }
        else if (timerShow <= 0)
        {
            timerShow = -10f;
            WarningText.gameObject.SetActive(false);
        }
        

    }
}
