using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scp999Options : CandidateOptions
{
    private IEnumerator coroutine;
    public Animator shutter;
    public Shutter shutterEvent;
    private AudioSource sludge;
    public AudioClip clip;
    public float sludgetime;
    public override void Accept()
    {
        if (cardError == true)
        {

            characterManager.citation.GetComponent<SpriteRenderer>().sprite = citationError;
            characterManager.citation.SetInteger("state", 1);


        }
        characterManager.Acceptprocedure();
    }

    public override void Enter()
    {
        shutterEvent.OnShutterChange += ShutterDown;
    }

    public override void Reject()
    {
        
    }

    private void ShutterDown(object sender, string direction)
    {
        if (direction == "down")
        {
            characterManager.Reject();
        }

    }

    public override void SCPButton()
    {
        Debug.Log("999");
        
        shutter.SetBool("down", true);
        StartCoroutine(Shutterup());
    }

    IEnumerator Shutterup()
    {
        yield return new WaitForSeconds(1.5f);
        shutter.SetBool("down", false);
    }

    public override void SheetButton()
    {
        
    }

    public override void ShutterButton()
    {
        
    }

    public override void MovedIn()
    {
        StartCoroutine(Sludge());
    }

    IEnumerator Sludge()
    {
        sludge.Play();
        yield return new WaitForSeconds(sludgetime);
        sludge.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Character>();
        sludge = GetComponent<AudioSource>();
        sludge.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
