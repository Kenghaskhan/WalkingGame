using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Paper = 0;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject text;
    private AudioSource playerAudio;
    public AudioClip ExitSound;
    private float Exitaudio = 1.0f;
    public AudioClip CrowSound;
    private float Crowaudio = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Paper >= 5)
        {
            wall1.SetActive(false);
            wall2.SetActive(false);
            text.SetActive(true);
            playerAudio.PlayOneShot(ExitSound, Exitaudio);
        }

        if (Paper >= 3)
        {
            playerAudio.PlayOneShot(CrowSound, Crowaudio);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 50, 50), Paper.ToString ());
    }
}
