using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerLevel1 : MonoBehaviour
{
    public NpcDialogueScript[] npcs;

    [SerializeField] private Animator Fade;
    [SerializeField] private Fade fadeScript;
    [SerializeField] private TextMeshProUGUI NPCCount;
    private int count = 0;
    private void Update()
    {
        if (npcs[0].Dialogue == true && npcs[1].Dialogue == true && npcs[2].Dialogue == true && npcs[3].Dialogue == true)
        {
            NPCSDone();
        }
        count = 0;
        for (int i = 0; i < npcs.Length; i++)
        {
            if (npcs[i].Dialogue == true)
            {
                count++;
            }
        }
        NPCCount.text = count.ToString() + "/4";
    }
    public void NPCSDone()
    {
        Debug.Log("WIN on to the next level!");
        Fade.SetBool("FadeOut", true);
    }
    
}
