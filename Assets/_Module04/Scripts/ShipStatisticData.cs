using UnityEngine;

[CreateAssetMenu(fileName = "ShipStatisticData", menuName = "Scriptable Objects/ShipStatisticData")]
public class ShipStatisticData : ScriptableObject
{
    public string shipName;
    public float shipSpeed;
    public float shipBoost;
    public float shipStrenght;
    public float shipPower;

}
