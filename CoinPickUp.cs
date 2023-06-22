using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public Collider2D CoinCollider;
    public Collider2D UfoCollider;
    public GameObject CoinObject;
    public int coin;
    // Start is called before the first frame update
    void Start()
    {
        
        //CoinCollider = GameObject.FindGameObjectWithTag("coin").GetComponent<Collider2D>();
        //UfoCollider = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
