using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPowerup : PickupPowerup
{
    [SerializeField] Powerup[] powerups;
    public override void ApplyPowerup(GameObject player)
    {
        int randomPowerupSelection = UnityEngine.Random.Range(0, powerups.Length);
        Instantiate(powerups[randomPowerupSelection], transform.position, powerups[randomPowerupSelection].transform.rotation);
        HidePowerup();
    }
}
