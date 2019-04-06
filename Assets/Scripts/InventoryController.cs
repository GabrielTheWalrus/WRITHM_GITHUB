using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    // Start is called before the first frame update
    //public Sprite[] sprites;

    public SpriteRenderer preFab;
    
    public SpriteRenderer[] go;

    private void Start()
    {
        int i, j = 0, x, y;
        go = new SpriteRenderer[15];
        for (i = 0; i < 15; i++)
        {
            go[i] = Instantiate<SpriteRenderer>(preFab);
        }
        while(j<15)
        {
            for(y=100; y >= -100; y -= 100)
            {
                for (x = -200; x <= 200; x += 100)
                {
                    go[j].transform.position = new Vector3(x, y, -2);
                    j++;
                }
            }
        }
    }

    
    
    void Update()
    {
        int i;
        for(i = 0; i < GameManager.Instance.contItem; i++)
            go[i].sprite = GameManager.Instance.inventario[0];
        

    }
}
