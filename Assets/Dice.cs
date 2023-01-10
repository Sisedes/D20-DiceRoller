using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody RigidbodyDice;
    public static Vector3 diceVelocity;
    void Start()
    {
        RigidbodyDice = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {diceVelocity=RigidbodyDice.velocity;
        
    }
    void rollDice()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Space))
        {
            DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            transform.position=new Vector3(0,2,0);
            transform.rotation = Quaternion.identity;
            RigidbodyDice.AddForce(transform.up * 500);
            RigidbodyDice.AddTorque(dirX, dirY, dirZ);
        }
    }
}
