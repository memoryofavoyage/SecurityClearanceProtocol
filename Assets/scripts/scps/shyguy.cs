using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shyguy : MonoBehaviour
{
    public SpriteRenderer page049;
    public GameObject page;
    public GameObject page096;
    public SpriteRenderer back;
    void OnMouseDown()
    {
        page096.SetActive(true);
        page.SetActive(false);
        back.enabled = true;
    }
}