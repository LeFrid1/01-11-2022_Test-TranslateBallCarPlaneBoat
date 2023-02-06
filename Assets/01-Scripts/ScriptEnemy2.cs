using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemy2 : MonoBehaviour
{
    private float speedEnemy2 = 4f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(1,-40,3) * speedEnemy2 * Time.deltaTime);
    }
   
}
