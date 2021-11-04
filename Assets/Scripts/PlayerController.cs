using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int lifePlayer = 3;
    [SerializeField] private string namePlayer = "Mr. Blue";
    [SerializeField] private float cameraAxisX = -90f;
    [SerializeField] private float speedPlayer = 1f;

       
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      Move();
      RotatePlayer();
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angulo   = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angulo;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.CompareTag("Portal")){

         transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                  
        }

        if(collision.gameObject.CompareTag("Wall")){

            
        }
      
    }

    private float tick;

    public GameObject[] spawnpoints;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            tick += Time.deltaTime;
            if (tick >= 2)
            {
                other.gameObject.transform.position = spawnpoints[0].transform.position;
                other.gameObject.transform.rotation = spawnpoints[0].transform.rotation;

                tick = 0;
            }
        }



    }

    
}