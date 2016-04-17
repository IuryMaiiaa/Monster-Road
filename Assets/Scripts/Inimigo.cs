using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {
    public int valor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setValorInimigo(int valor)
    {
        this.valor = valor;
    }

    public int getValorInimigo()
    {
        return valor;
    }
}
