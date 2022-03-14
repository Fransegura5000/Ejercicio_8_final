using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarObjetos : MonoBehaviour
{

    private int sizex = 500;
    private int sizey = 500;
    private int sizez = 500;


    public void EscaladoObjeto(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * Vector3.one * 10;

    }


}
