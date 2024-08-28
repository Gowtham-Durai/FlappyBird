using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource Audio;
    [Header("------Audio Clip------")]
    
    public AudioClip Point;
    public AudioClip Swoosh;
    public AudioClip die;
    public AudioClip wing;

    // Start is called before the first frame update
   public void addSFX(AudioClip clip){
        Audio.PlayOneShot(clip);
   }
}
