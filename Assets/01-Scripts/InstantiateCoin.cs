using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCoin : MonoBehaviour
{
    public GameObject prefabCoin;
    public Transform[] spawnCoinsPosition;
    [SerializeField] private float vitesse = 100f;
    void Start()
    {
        for (int i = 0; i < spawnCoinsPosition.Length; i++)
        {
            Instantiate(prefabCoin, spawnCoinsPosition[i].transform.position, Quaternion.identity);
            transform.Rotate(new Vector3(1,0,0) * vitesse *Time.deltaTime);
        }

    }

   void Update()
    {
        
    }
}
