using UnityEngine.Audio;
using UnityEngine;

public class SoundObject : MonoBehaviour
{
    public string name;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;
}
