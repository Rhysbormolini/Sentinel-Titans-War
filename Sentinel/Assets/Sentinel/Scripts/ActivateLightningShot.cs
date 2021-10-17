using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLightningShot : MonoBehaviour
{
    public GameObject zapZap;
    public float shotTime;

    private void Update()
    {
        if (zapZap == true)
        {
            StartCoroutine("TurnOffZapZap");
        }
        return;
    }

    IEnumerator TurnOffZapZap()
    {
        yield return new WaitForSeconds(shotTime);
        zapZap.SetActive(false);
    }
}
