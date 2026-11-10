using System;
using UnityEngine;

public class ChangeSoundEffectManager : MonoBehaviour
{
    private static ChangeSoundEffectManager _instance;
    private AudioSource SoundEffectSource;
    [Header("Звуки")]
    public AudioClip ButtonPress;

    void Awake()
    {
        if(_instance!=null&&_instance!=this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        SoundEffectSource = GetComponent<AudioSource>();
    }
    public static void PlayButtonPress()=>PlayEffect(_instance.ButtonPress)    ;
    private static void PlayEffect(AudioClip clip)
    {
        if (_instance == null || clip == null || _instance.ButtonPress == null) return;
        _instance.SoundEffectSource.PlayOneShot(clip);
    }

    
}
