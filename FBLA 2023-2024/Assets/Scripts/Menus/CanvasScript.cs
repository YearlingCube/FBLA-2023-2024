using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    [SerializeField] AnimationManager AM;
    public void Display()
    {
        AM.StartDialogueWithJudge();
    }
}
