using UnityEngine;

[CreateAssetMenu(fileName = "PersonData", menuName = "Scriptable Objects/PersonData")]
public class PersonData : ScriptableObject
{
    public string pName="";
    public string age="";
    public string origin = "";
    public string callsign = "";
    public string StoryGetCallsign="";
    public string strenghtSide = "";
    public string motivationSide = "";

    public Sprite icon;
}
