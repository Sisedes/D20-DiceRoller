using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceChecK : MonoBehaviour
{
    Vector3 diceVelocity;

    private void FixedUpdate()
    {
        diceVelocity = Dice.diceVelocity;
    }
    private void OnTriggerStay(Collider other)
    {
        if(diceVelocity.x==0f&& diceVelocity.z == 0f)
        {
            switch (other.gameObject.name)
            {  case "Side1":
                    DiceNumberTextScript.diceNumber = 20;
                    break;
                case "Side2":
                    DiceNumberTextScript.diceNumber = 19;
                    break;
                case "Side3":
                    DiceNumberTextScript.diceNumber = 18;
                    break;
                case "Side4":
                    DiceNumberTextScript.diceNumber = 17;
                    break;  
                case "Side5":
                    DiceNumberTextScript.diceNumber = 16;
                    break;
                case "Side6":
                    DiceNumberTextScript.diceNumber = 15;
                    break;
                case "Side7":
                    DiceNumberTextScript.diceNumber = 14;
                    break;
                case "Side8":
                    DiceNumberTextScript.diceNumber = 13;
                    break;
                case "Side9":
                    DiceNumberTextScript.diceNumber = 12;
                    break;
                case "Side10":
                    DiceNumberTextScript.diceNumber = 11;
                    break;
                case "Side11":
                    DiceNumberTextScript.diceNumber = 10;
                    break;
                case "Side12":
                    DiceNumberTextScript.diceNumber = 9;
                    break;
                case "Side13":
                    DiceNumberTextScript.diceNumber = 8;
                    break;
                case "Side14":
                    DiceNumberTextScript.diceNumber = 7;
                    break;
                case "Side15":
                    DiceNumberTextScript.diceNumber = 6;
                    break;
                case "Side16":
                    DiceNumberTextScript.diceNumber = 5;
                    break;
                case "Side17":
                    DiceNumberTextScript.diceNumber = 4;
                    break;
                case "Side18":
                    DiceNumberTextScript.diceNumber = 3;
                    break;
                case "Side19":
                    DiceNumberTextScript.diceNumber = 2;
                    break;
                case "Side20":
                    DiceNumberTextScript.diceNumber = 1;
                    break;

            }
        }
    }
}
