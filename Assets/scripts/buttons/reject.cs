using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reject : MonoBehaviour
{
    public CharacterManager manager;
    private AudioSource rejectsound;
    public AudioClip clip;
    public GameObject keycardsprite;
    public GameObject timetablesprite;
    public citation Citation;
    public AudioClip citationsound;
    public AudioSource mySource;
    public float myVolume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rejectsound = GetComponent<AudioSource>();
        rejectsound.clip = clip;
    }
    void OnMouseDown()
    {
        if (CharacterManager.isDead) { return; }
        manager.Reject();
        rejectsound.Play();
        keycardsprite.SetActive(false);
        timetablesprite.SetActive(false);
        StartCoroutine(citationmoment());
    }
    IEnumerator citationmoment()
    {
        mySource.PlayOneShot(citationsound, myVolume);
        Citation.Waiting = false;
        yield return new WaitForSeconds(4);
        Citation.Waiting = false;
    }
}
