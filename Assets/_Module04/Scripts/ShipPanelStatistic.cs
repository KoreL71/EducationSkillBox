using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShipPanelStatistic : MonoBehaviour
{
    [SerializeField] private GameObject _panelShipCharacteristic;
    [SerializeField] private  Image _speedVisualsIcon;
    [SerializeField] private Image _boostVisualsIcon;
    [SerializeField] private Image _strenghtVisualsIcon;
    [SerializeField] private Image _powerVisualsIcon;
    [SerializeField] private TMP_Text _namedShip; 
    public void SettingDataCharacteristic(ShipStatisticData statistic)
    {
        _speedVisualsIcon.fillAmount += statistic.shipSpeed;
        _boostVisualsIcon.fillAmount += statistic.shipBoost;
        _strenghtVisualsIcon.fillAmount += statistic.shipStrenght;
        _powerVisualsIcon.fillAmount += statistic.shipPower;
        _namedShip.text= statistic.shipName;
    }
    public void RemoveDataCharacteristic(ShipStatisticData statistic)
    {
        _speedVisualsIcon.fillAmount -= statistic.shipSpeed;
        _boostVisualsIcon.fillAmount -= statistic.shipBoost;
        _strenghtVisualsIcon.fillAmount -= statistic.shipStrenght;
        _powerVisualsIcon.fillAmount -= statistic.shipPower;
        _namedShip.text = statistic.shipName;
    }
}
