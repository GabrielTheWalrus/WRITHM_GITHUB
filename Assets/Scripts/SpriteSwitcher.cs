using UnityEngine;
using UnityEngine.UI;

public class SpriteSwitcher : MonoBehaviour
{
    public Sprite[] sprites;
    public float interval;

    Image image;
    SpriteRenderer sr;
    float curTime;
    int spriteIdx;
    bool right;

    void Start()
    {
        image = GetComponent<Image>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (((Camera.main.ScreenToWorldPoint(Input.mousePosition).x) - (sr.gameObject.transform.position.x)) >= 0)
            {
                right = true;
            }
            else
                right = false;
        }
        if (GameManager.Instance.Move)
        {
            sr.flipX = !right;
            
            curTime += Time.deltaTime;
            if (curTime >= interval)
            {
                curTime -= interval;
                spriteIdx = (spriteIdx + 1) % sprites.Length;

                if (image)
                    image.sprite = sprites[spriteIdx];

                if (sr)
                    sr.sprite = sprites[spriteIdx];
            }
        }
    }

    
    
}
