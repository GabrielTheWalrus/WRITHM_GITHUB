using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject go;
    

    void Update()
    {
        
        if (GameManager.Instance.teste)
        {
            if ((GameManager.Instance.Collider) && !(GameManager.Instance.Move))
            {
                GameManager.Instance.inventario[GameManager.Instance.contItem] = sr.sprite;
                GameManager.Instance.contItem++;
                go.SetActive(false);
                Debug.Log(GameManager.Instance.inventario[0]);

                GameManager.Instance.teste = false;
               
            }
            GameManager.Instance.Collider = false;
            
       //     Destroy(go);
        }
        if (!GameManager.Instance.teste)
            go.SetActive(false);

    }
    /*
    void OnMouseDown()
    {
        if ((go.name == "teste") && (GameManager.Instance.Collider) && !(GameManager.Instance.Move))
        {
            Debug.Log(go.name);
            
        }
    }*/
}
