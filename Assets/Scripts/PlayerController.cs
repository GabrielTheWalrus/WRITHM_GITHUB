using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.actualPosition != Vector2.zero)
        {
            transform.position = GameManager.Instance.actualPosition;
            targetPosition = GameManager.Instance.actualPosition;
        }
        Debug.Log(GameManager.Instance.actualPosition);
    }

    // Update is called once per frame
        // Update is called once per frame
    public void FixedUpdate()
    {

        if ((Input.GetKeyDown(KeyCode.Mouse0)) && !(GameManager.Instance.Collider))
        {
            GameManager.Instance.Move = true;
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        if (!(GameManager.Instance.Collider))
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 150);
        

        if ((targetPosition.x == transform.position.x) && (targetPosition.y == transform.position.y))
            GameManager.Instance.Move = false;
        
    }

    public void OnMouseDown()
    {
        GameManager.Instance.Move = true;
        GameManager.Instance.Collider = false;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("limiter"))
        {
            //GameManager.Instance.Collider = true;

            GameManager.Instance.Move = false;
            return;
        }
        if (collision.gameObject.CompareTag("gateRight"))
        {
            SceneManager.LoadScene("City2");
            return;
        }
        if (collision.gameObject.CompareTag("teste"))
        {
            GameManager.Instance.Collider = true;
            targetPosition = collision.gameObject.transform.position;//Vector2.MoveTowards(transform.position, collision.gameObject.transform.position, Time.deltaTime * 150);
            GameManager.Instance.Move = false;
            return;
        }


        //GameManager.Instance.Collider = true;

        /*if (collision.gameObject.CompareTag("teste"))
        {
            GameManager.Instance.inventario[0] = 1;
            Debug.Log(GameManager.Instance.inventario[0]);
            GameManager.Instance.Move = false;
            GameObject temp = GameObject.Find("teste");
            temp.SetActive(false);

        }*/

    }
    /*
    void OnMouseDown()
    {

        if ((gameObject.tag == "teste") && (this.item == true))
        {
            GameManager.Instance.inventario[0] = 1;
            Debug.Log(GameManager.Instance.inventario[0]);
            GameManager.Instance.Move = false;
            GameObject temp = GameObject.Find("teste");
            temp.SetActive(false);
        }

    }
    *//*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray.origin.ToString());

            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider != null)
                {
                    Debug.Log("teste is clicked by mouse");
                }

            
            }
        }

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
        // Call a damage function on the object we hit.
        if (hit.gameObject.name == "teste") {
            
            Debug.Log("teste is clicked by mouse");
        }
    }*/


}
