using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scp096Options : CandidateOptions
{
    public float docileTime;
    public Sprite look;
    private IEnumerator coroutine;
    public Animator shutter;
    public Shutter shutterEvent;
    public CharacterManager manager;
    public GameObject gameover;
    private AudioSource baresteps;
    public AudioClip clip;
    public AudioClip scream;
    public float baresteptime;
    public float myVolume = 0.05f;

    public override void Accept()
    {

    }

    public override void Enter()
    {
        coroutine = DocileCountdown();
        StartCoroutine(coroutine);
        shutterEvent.OnShutterChange += ShutterDown;
    }
    

    private void ShutterDown(object sender, string direction)
    {
        if (direction == "down")
        {
            manager.Reject();
        }

    }

    IEnumerator DocileCountdown()
    {
        yield return new WaitForSeconds(docileTime);
        baresteps.PlayOneShot(scream, myVolume);
        gameover.SetActive(true);
        Debug.Log("dead");
        CharacterManager.isDead = true;
        manager.TriggerAnimation("attack");
    }

    private void ChangeSprite()
    {
        characterManager.ChangeSprite(look);
    }
    public override void Reject()
    {

    }

    public override void SCPButton()
    {
        StopCoroutine(coroutine);
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
        StartCoroutine(Baresteps());
    }
    IEnumerator Baresteps()
    {
        baresteps.Play();
        yield return new WaitForSeconds(baresteptime);
        baresteps.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Character>();
        baresteps = GetComponent<AudioSource>();
        baresteps.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
