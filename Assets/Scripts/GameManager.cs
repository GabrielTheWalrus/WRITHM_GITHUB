using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance = null;

    public bool Move = false;
    public bool Collider = false;
    public bool teste = true;

    public float ScrollSpeed = 2; //sky scroll speed
    public string presentScene;

    //public string[] inventario = new string[10];
    public Sprite[] inventario = new Sprite[15];
    public int contItem = 0;

    public Vector2 actualPosition;



    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GM").AddComponent<GameManager>();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        
    }

}
