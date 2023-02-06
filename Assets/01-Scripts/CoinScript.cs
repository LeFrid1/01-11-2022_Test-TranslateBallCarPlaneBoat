using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private float vitesse = 100f;
   
    void Start()
    {
        transform.Rotate(new Vector3(2f,0f,0f) * vitesse *Time.deltaTime);
    }

   
    void Update()
    {
        transform.Rotate(new Vector3(2f,0f,0f) * vitesse *Time.deltaTime);
    }
}
