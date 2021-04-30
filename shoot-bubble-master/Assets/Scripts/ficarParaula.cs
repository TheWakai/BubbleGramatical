using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ficarParaula : MonoBehaviour
{
    public Text paraula;
    public static int num;

    void Start()
    {
        num=Hitter.kind;
        Hitter.paraules(paraula, num);
	}
}