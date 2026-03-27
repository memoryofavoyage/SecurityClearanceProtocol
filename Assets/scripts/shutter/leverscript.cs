using System;
using UnityEngine;

public class leverscript : MonoBehaviour
{
    public bool lever = true;
    public Shutter Shutter;
    private AudioSource shutter;
    public AudioClip clip;
    public Animator shutteranim;
    public Animator leveranim;
    public CharacterManager characterManager;
    public bool down = false;
    public event EventHandler<string> OnLeverChange;
    // Start is called before the first frame update
    void Start()
    {
        shutter = GetComponent<AudioSource>();
        shutter.clip = clip;

        leveranim.speed = 0f;
    }

    void OnMouseDown()
    {
        Debug.Log("lever");
        if (CharacterManager.isDead) { return; }

        // Toggle Lever (Invert it)
        lever = !lever;

        // Do Animation
        leveranim.speed = 1f; // Lazy fix.
        shutteranim.SetBool("down1", !shutteranim.GetBool("down1"));
        leveranim.SetBool("IsOn", lever);

        //leveranim.SetBool("down", !shutteranim.GetBool("down"));


        // leveranim.SetBool("down", false);
        //if (down == false)
        //{
        //     leveranim.SetBool("down", true);

        //  }
        //  else
        // {
        //     leveranim.SetBool("up", true);

        // }
    }

    public void LeverMoved(string direction)
    {
        OnLeverChange?.Invoke(this, direction);
    }
}