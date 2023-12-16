using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrowSound : MonoBehaviour
{
    private AudioSource PlayerAudio;
    public AudioClip CrowSoundC;
    private float Crowaudio = 1.0f;


    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            PlayerAudio.PlayOneShot(CrowSoundC, Crowaudio);

        }
    }
}
