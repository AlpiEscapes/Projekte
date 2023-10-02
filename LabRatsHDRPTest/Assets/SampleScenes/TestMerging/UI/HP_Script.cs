using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Script : MonoBehaviour
{
    public Image HPBar;

    public void SetHealth(int currentHealth)
    {
        HPBar.fillAmount = (float) currentHealth / 100.0f;
    }

}
