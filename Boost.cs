using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boost : PowerUp
{
    [SerializeField]
    float multiplier;
    public override void UsePowerUp(int playerUsed)
    {
        PlayerBody pb = GameManager.gameManager.playerBody[playerUsed];
        pb.GetComponent<Rigidbody>().AddForce(multiplier*GameManager.gameManager.cameras[playerUsed].transform.forward, ForceMode.VelocityChange);
    }
}
