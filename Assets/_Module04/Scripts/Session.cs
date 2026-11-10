using UnityEngine;

public static class Session 
{
    private static CharacterData character;
    public static CharacterData Data => character;
    public static void SetCharacter(CharacterData data)
    {
        character = data;
    }
    public static bool HasPlayer => character != null;
}
