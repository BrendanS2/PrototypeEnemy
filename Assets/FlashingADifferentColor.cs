using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingADifferentColor : MonoBehaviour
{
    public SpriteRenderer cube;
    public SpriteRenderer Enemy;
    public float Distance;
    [SerializeField] float apart;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(cube.transform.position, Enemy.transform.position);
        if(Distance < apart)
        {
            Enemy.color = Color.red;
        }
        else
        {
            Enemy.color = Color.gray;

        }
    }

    
}
