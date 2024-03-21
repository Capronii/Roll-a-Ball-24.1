using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    [SerializeField] AudioSource backgroundSource;
    
    public AudioClip backgroundClip;

    private void Start()
    {
        backgroundSource.clip= backgroundClip;
        backgroundSource.Play();
    }


}
