using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryCaller : MonoBehaviour
{
    public GameObject go;
    
    
    public void OnMouseDown()
    {

        Debug.Log("entrei");
        if (go.name == "roberttto")
        {
            GameManager.Instance.actualPosition = go.transform.position;
            Debug.Log(GameManager.Instance.actualPosition);
            Scene presentScene = SceneManager.GetActiveScene();
            GameManager.Instance.presentScene = presentScene.name;
            SceneManager.LoadScene("Inventory");
        }
        if (go.name == "InventoryExit")
            SceneManager.LoadScene(GameManager.Instance.presentScene);
       
    }
    
}
