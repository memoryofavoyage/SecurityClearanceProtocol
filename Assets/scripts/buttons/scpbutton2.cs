using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpbutton2 : MonoBehaviour
{
    private AudioSource alarm;
    public AudioClip clip;
    public float alarmtime;
    
    // Start is called before the first frame update
    void Start()
    {
        alarm = GetComponent<AudioSource>();
        alarm.clip = clip;
        
    }

    IEnumerator Alarm()
    {
        alarm.Play();
        yield return new WaitForSeconds(alarmtime);
        alarm.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        StartCoroutine(Alarm());
        //StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        alarm.Stop();
       
    }
}
