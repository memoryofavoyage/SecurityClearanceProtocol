using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard : MonoBehaviour
{
    private AudioSource footstep;
    public AudioClip clip;
    public float speed = 1;
    public Shutter shutter;
    public GameObject scpContained;
    private Animator animator;
    public float waitnumber;
    // Start is called before the first frame update
    void Start()
    {
        footstep = GetComponent<AudioSource>();
        footstep.clip = clip;
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        shutter.OnShutterChange += HandleShutter;
    }

    private void HandleShutter(object sender, string direction)
    {
        Debug.Log("guard notified");
        if (direction == "up")
        {
            scpContained.SetActive(true);
            StartCoroutine(Goback());
        }
        if (direction == "down")
        {
            animator.SetTrigger("fadein");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move()
    {
        Debug.Log("go back");
        footstep.Play();

    }
    IEnumerator Goback()
    {
        yield return new WaitForSeconds(waitnumber);
        animator.SetTrigger("off");
        StopwalkingSound();
        scpContained.SetActive(false);
    }
    public void StopwalkingSound()
    {
        footstep.Stop();
    }
}
