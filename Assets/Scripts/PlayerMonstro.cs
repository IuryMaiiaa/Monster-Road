using UnityEngine;
using System.Collections;

public class PlayerMonstro : MonoBehaviour {
    public int pessoasDevoradas;

	// Use this for initialization
	void Start () {
        pessoasDevoradas = 0;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0,0,0.5f));
        if(Input.GetKeyDown("left"))
        {
            virarEsquerda();
        } else if (Input.GetKeyDown("right"))
        {
            virarDireita();
        }
	}

    public void virarDireita()
    {
        this.transform.Rotate(new Vector3(0,10,0));    
    }

    public void virarEsquerda()
    {
        this.transform.Rotate(new Vector3(0,-10, 0));
    }

    public void consumir(int quantidadePessoas)
    {
        pessoasDevoradas += quantidadePessoas;
    }

    void OnCollisionEnter(Collider coll)
    {

    }
}
