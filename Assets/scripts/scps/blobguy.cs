using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobguy : MonoBehaviour
{
    public SpriteRenderer page049;
    public GameObject page;
    public SpriteRenderer page096;
    public SpriteRenderer page173;
    public GameObject page999;
    public SpriteRenderer back;
    void OnMouseDown()
    {
        page999.SetActive(true);
        page.SetActive(false);
        back.enabled = true;
    }
}
