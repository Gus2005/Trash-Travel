using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public GameObject Trash;
    // Start is called before the first frame update
    void Start()
    {
        Trash = Trash;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Iceberg")
        {
            Destroy
        }
    }
}
