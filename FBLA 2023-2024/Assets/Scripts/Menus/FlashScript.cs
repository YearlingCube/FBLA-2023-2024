using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour
{
    public void FlashDone()
    {
        this.gameObject.SetActive(false);
    }
}
