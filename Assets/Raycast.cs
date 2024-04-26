using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField]float meanRange;
    [SerializeField] float moveSpeed;

    Rigidbody2D rigid2d;

    void Start()
    {
        rigid2d.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}