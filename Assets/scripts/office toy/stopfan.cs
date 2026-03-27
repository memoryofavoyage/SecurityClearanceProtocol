using UnityEngine;

public class stopfan : MonoBehaviour
{
    public Animator fan;
    public bool fanbool = true;
    private AudioSource fansound;
    public AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fansound = GetComponent<AudioSource>();
        fansound.Play();
        fansound.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        
        fanbool = !fanbool;

        // Do Animation
        fan.speed = 1f; // Lazy fix.
        fan.SetBool("turnoff", !fan.GetBool("turnoff"));
        if (fan.GetBool("turnoff"))
        {
            fansound.Stop();
            Debug.Log("sound stopped");
        }
        else
        {
            fansound.Play();
            Debug.Log("sound playing");
        }
        
    }
}
