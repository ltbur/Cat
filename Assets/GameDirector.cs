using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGage;

    public void DecreaseHp(){
        hpGage.fillAmount -= 0.1f;
    }
}
