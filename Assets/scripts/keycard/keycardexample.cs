using UnityEngine;

public class keycardexample : MonoBehaviour
{
    public GameObject keycardzoom;
    public AudioSource mySource;
    public AudioClip card;
    public GameObject keycardsprite;
    private bool SoundPlayed = false;
    public AudioClip documents;
    public float myVolume = 1.0f;
    public GameObject avatar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keycardsprite.activeSelf && !SoundPlayed)
        {
            docu();
        }
    }
    void OnMouseDown()
    {
        if (CharacterManager.isDead) { return; }
        keycardzoom.SetActive(true);
        mySource.PlayOneShot(card, 1.0f);
        avatar.SetActive(true);
    }
    void docu()
    {
        if(documents != null)
        {
            mySource.PlayOneShot(documents, myVolume);
            SoundPlayed = true;
        }
        
    }
}
