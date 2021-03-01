using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public SoundObject[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(SoundObject s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
        }
    }

    public void Play(string name)
    {
        SoundObject s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        s.source.Play();
    }

    public void Stop(string name)
    {
        SoundObject s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        s.source.Stop();
    }

}
