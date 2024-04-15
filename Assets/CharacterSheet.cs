using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.ContentSizeFitter;

public class CharacterSheet : MonoBehaviour
{
    //Player character stats
    [SerializeField] string player = "Steve";
    [SerializeField] int pro_Bonus = 0;
    [SerializeField] bool weapon = false;
    [SerializeField] int str = 0;
    [SerializeField] int dex = 0;
    // int enemy = 0;
    int hitMod = 0;

    //Enemy 
    //int armor_Class = 0;

    //calculations
    


    // Start is called before the first frame update
    void Start()
    {

        //int ranNum = (Random.Range(0, 6));

        //Debug.Log(ranNum);
        if (weapon != true)
        {
            hitMod = hitMod + pro_Bonus + str;
            Debug.Log((player) + ("'s hit modifer is ") + (hitMod));
        }
        else if (dex > str)
        {
            hitMod = hitMod + pro_Bonus + dex;
            Debug.Log((player) + ("'s hit modifer is ") + (hitMod));
        }
        else
        {
            hitMod = hitMod + pro_Bonus + str;
            Debug.Log((player) + ("'s hit modifer is ") + (hitMod));
        }

      // Debug.Log((player) + ("'s hit modifier is ") + (ranNum));

        int enNum = (Random.Range(10, 21));
        //enemy = (enemy + enNum);
        //Debug.Log(enNum);
        Debug.Log(("Enemy AC is ") + (enNum));

        int dNum = (Random.Range(1, 21));
        Debug.Log((player) + (" rolled a ") + (dNum));

        hitMod = hitMod + dNum;
        if (hitMod < dNum)
        {
            Debug.Log("You missed");
        }
        else
        {
            Debug.Log("Enemy is hit");
        }





    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
}
