using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [Header("Звуковые компоненты")]
    public AudioSource music;
    public AudioSource soundEffect;
    [Header("UI компоненты")]
    public Slider musicVolume;
    public Slider soundEffectVolume;

    public Image imageMusic;
    public Image imageSoundEffect;

    public Sprite onMusic,offMusic,onSoundEffect,offSoundEffect;

    public 
    
    void Start()
    {
        musicVolume.value = music.volume;
        soundEffectVolume.value = soundEffect.volume;
    }
    void OnEnable()
    {
        if (musicVolume != null)
        {
            musicVolume.onValueChanged.AddListener(SetVolumeMusic);
        }
        if(soundEffectVolume != null)
        {
            soundEffectVolume.onValueChanged.AddListener(SetVolumeSoundEffect);
        }
    }
    private void OnDisable()
    {
        if (musicVolume != null)
        {
            musicVolume.onValueChanged.RemoveListener(SetVolumeMusic);
        }
        if (soundEffectVolume != null)
        {
            soundEffectVolume.onValueChanged.RemoveListener(SetVolumeSoundEffect);
        }
    }
    public void SetVolumeMusic(float value)
    {
        music.volume = value;
         if(musicVolume.value >0)
        {
            imageMusic.sprite = onMusic;
        }
        if(musicVolume.value == 0)
        {
            imageMusic.sprite=offMusic;
        }
    }
    public void SetVolumeSoundEffect(float value)
    {
        soundEffect.volume = value ;
       if (soundEffectVolume.value > 0)
        {
            imageSoundEffect.sprite = onSoundEffect;
        }
        else if (soundEffectVolume.value == 0)
        {
            imageSoundEffect.sprite = offSoundEffect;
        }
    }
    }
  
