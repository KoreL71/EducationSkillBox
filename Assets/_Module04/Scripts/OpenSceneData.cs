using UnityEngine;

[System.Serializable]
public class OpenSceneData 
{
    public string playerName;
    public int playerAge;

    public bool isMale,isFemale;
    public Sprite playerIcon;

    public string originText, callsignText, informationText;
}
public class OpenSceneSession : MonoBehaviour
{
    private static OpenSceneSession instance;
    
    public static OpenSceneSession Instance
    {
        get
        {
            if (instance == null)
            {
                var doit = new GameObject("OpenSceneSession");
                instance = doit.AddComponent<OpenSceneSession>();
                DontDestroyOnLoad(doit);
            }
            return instance;
        }
    }
    public OpenSceneData playerData= new OpenSceneData();
    
    
}

