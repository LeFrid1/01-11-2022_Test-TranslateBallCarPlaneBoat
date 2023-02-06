using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemy1 : MonoBehaviour
{
    private float speed = 4f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(1,40,3) * speed * Time.deltaTime);
    }
   
}
