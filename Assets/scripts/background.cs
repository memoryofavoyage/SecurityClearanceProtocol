using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class background : MonoBehaviour
{
    public GameObject[] popups; 
    private AudioSource ambience;
    public AudioClip clip;
    public TMP_Text spacetext;
    public bool spacedone;
    public GameObject avatar;
    void Start()
    {
        ambience = GetComponent<AudioSource>();
        ambience.clip = clip;
        ambience.Play();
        spacedone = false;
    }
    void OnMouseDown()
    {
        Debug.Log("background", gameObject);
        if (spacedone == false)
        {
            spacetext.enabled = true;
        }
        spacedone = true;
        avatar.SetActive(false);

        ShowPopup(null);
    }

    public void ShowPopup(GameObject popup)
    {
        foreach (GameObject item in popups)
        {
            item.SetActive(item == popup);
        }
    }
}
