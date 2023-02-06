using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCarPlayer : MonoBehaviour
{
    private float speed = 6f;
    [SerializeField] private float zForce = 1f;
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(0f, 0f, zForce);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(0f, 0f, -zForce);
        }

    }
}
