 using UnityEngine;

public class smallsquare : MonoBehaviour
{
    public SpriteRenderer bigSquare;

    void OnMouseDown()
    {
        bigSquare.enabled = true;
    }
}
