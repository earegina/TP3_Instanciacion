using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionController : MonoBehaviour
{
    public float speedMunition = 3.0f;
    public float damage = 100f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }
    private void MoveBullet()
    {
        transform.Translate(speedMunition * Time.deltaTime * Vector3.forward);
    }
}
