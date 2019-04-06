using UnityEngine;

public class SkyScroller : MonoBehaviour
{

    float spriteWidth;

    void Start()
    {
        GameObject rightGO = Instantiate<GameObject>(gameObject, transform);
        Sprite sprite = rightGO.GetComponent<SpriteRenderer>().sprite;
        spriteWidth = sprite.bounds.size.x;
        rightGO.transform.localPosition = new Vector3(spriteWidth, 0, 0);
        Destroy(rightGO.GetComponent<SkyScroller>());
    }

    void Update()
    {
        Vector3 curPos = transform.position;
        curPos.x -= GameManager.Instance.ScrollSpeed * Time.deltaTime;

        if (curPos.x < -spriteWidth)
            curPos.x += spriteWidth;

        transform.position = curPos;
    }
}
