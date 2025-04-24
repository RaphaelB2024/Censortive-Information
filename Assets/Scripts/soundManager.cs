using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager instance;

    [SerializeField] private AudioSource sfxObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void playClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawn gameobject
        AudioSource audioSource = Instantiate(sfxObject, spawnTransform.position, Quaternion.identity);

        //assign audioclip
        audioSource.clip = audioClip;

        //assign volume
        audioSource.volume = volume;
        
        //play sound
        audioSource.Play();
        
        //length of clip
        float clipLength = audioSource.clip.length;

        //destroy clip
        Destroy(audioSource.gameObject);
    }
}
