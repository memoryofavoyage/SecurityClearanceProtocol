using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class Highlight : MonoBehaviour
{
    public Sprite highlightedSprite;
    public Sprite normalSprite;
    private SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }

    private void OnMouseEnter()
    {
        spriteRenderer.sprite = highlightedSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = normalSprite;
    }
}
