using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip EndSound;
    private float Endaudio = 1.0f;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            playerAudio.PlayOneShot(EndSound, Endaudio);
            SceneManager.LoadScene("EndGameMenu");
            
        }
    }
}
