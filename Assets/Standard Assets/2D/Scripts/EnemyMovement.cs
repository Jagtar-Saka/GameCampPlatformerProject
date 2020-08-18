using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;
    SpriteRenderer mySprRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mySprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Vector2.Distance(transform.position, Player.position) * Time.deltaTime;

            if (Vector2.Distance(transform.position, Player.position) <= MaxDist)
            {


            }

        }
    }
}


