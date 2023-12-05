using System.Collections;
using System.Collections.Generic;
using Hertzole.GoldPlayer;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip PaperSound;
    private float Paperaudio = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Paper")
        {
            playerAudio.PlayOneShot(PaperSound, Paperaudio);
        }
    }
}
