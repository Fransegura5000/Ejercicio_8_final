using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Renderer cuadradoRend;
    private Color colorNuevo;
    private float colorRandom1, colorRandom2, colorRandom3;

    // Start is called before the first frame update
    void Start()
    {
        cuadradoRend = player.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeColorFuncion);
    }

    public void ChangeColorFuncion()
    {
        colorRandom1 = Random.Range(0f, 1f);
        colorRandom2 = Random.Range(0f, 1f);
        colorRandom3 = Random.Range(0f, 1f);

        colorNuevo = new Color(colorRandom1, colorRandom2, colorRandom3, 1f);

        cuadradoRend.material.SetColor("_Color", colorNuevo);
    }
}