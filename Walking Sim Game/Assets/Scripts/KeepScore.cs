using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Paper = 0;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject text;
    private AudioSource PlayerAudio;
    public AudioClip CrowSound;
    private float Crowaudio = 1.0f;
    public AudioClip Exitsound;
    private float Exitaudio = 1.0f;
    private bool CrowAudioP = false;
    private bool ExitAudioP = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Paper >= 3 && CrowAudioP == false)
        {
            PlayerAudio.PlayOneShot(CrowSound, Crowaudio);
            Debug.Log("CrowSound");
            CrowAudioP = true;
        }

        if (Paper >= 5 && ExitAudioP == false)
        {
            wall1.SetActive(false);
            wall2.SetActive(false);
            text.SetActive(true);
            PlayerAudio.PlayOneShot(Exitsound, Exitaudio);
            Debug.Log("ExitSound");
            ExitAudioP = true;
        }

    }

    void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 50, 50), Paper.ToString ());
    }
}
