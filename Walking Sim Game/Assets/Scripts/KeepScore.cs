using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Paper = 0;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Paper >= 1)
        {
            wall1.SetActive(false);
            wall2.SetActive(false);
            text.SetActive(true);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 50, 50), Paper.ToString ());
    }
}
