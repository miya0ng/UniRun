using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        width = sr.sprite.rect.width / sr.sprite.pixelsPerUnit;
        //var col = GetComponent<BoxCollider2D>();
        //width = col.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            transform.position = new Vector3(width, 0f, 0f);
        }
    }
}
