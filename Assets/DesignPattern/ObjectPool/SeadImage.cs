using UnityEngine;

public class SeadImage : MonoBehaviour
{
    public Sprite[] growImage;

    private SpriteRenderer spriteRenderer;
    private int cnt = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null )
        {
            spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        }

        if (growImage.Length > 0 )
        {
            spriteRenderer.sprite = growImage[0];
        }
    }

    public void Grow()
    {
        if (cnt < growImage.Length - 1)
        {
            cnt++;
            spriteRenderer.sprite = growImage[cnt];
        }
    }
}