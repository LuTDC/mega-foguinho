using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public Sound[] sounds;
    
    public static AudioController instance;

    void Awake()
    {
       CheckInstance();

       AddSource();  
    }

    void Start()
    {
        Play("Theme");
    }

    void CheckInstance()
    {
        if(instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void AddSource()
    {
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            
            sound.source.clip = sound.clip;

            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;

            sound.source.loop = sound.loop;
        }
    }

    public void Play(string name)
    {
        Sound playSound = Array.Find(sounds, sound => sound.name == name);

        if(playSound == null)
        {
            Debug.Log("Sound not found");

            return;
        }

        playSound.source.Play();
    }
}