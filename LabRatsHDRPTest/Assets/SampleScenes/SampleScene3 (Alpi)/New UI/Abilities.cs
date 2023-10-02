using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{

    public GameObject img;

    private float cooldown = 10;
    // Start is called before the first frame update


    //diese methode mit dem richtigen index ausführen um das UI element für 10 sekunden auszublenden
    public void ChangeAbilities(int i)
    {
        img.transform.GetChild(i).gameObject.SetActive(true);
        StartCoroutine("DisableAbility", i);
        
    }

    IEnumerator DisableAbility(int i)
    {
        yield return new WaitForSeconds(cooldown);
        img.transform.GetChild(i).gameObject.SetActive(false);
    }
}
