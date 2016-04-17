using UnityEngine;
using System.Collections;

public class PlayerMonstro : MonoBehaviour {
    public int pessoasDevoradas;

	// Use this for initialization
	void Start () {
        pessoasDevoradas = 1;
	}

   
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0,0,0.25f));
        if(Input.GetKeyDown("left"))
        {
            virarEsquerda();
        } else if (Input.GetKeyDown("right"))
        {
            virarDireita();
        }
        AtualizarTamanhoMonstro();
	}

    public void AtualizarTamanhoMonstro()
    {
        this.transform.localScale = new Vector3(pessoasDevoradas, pessoasDevoradas, pessoasDevoradas);
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

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("inimigo"))
        {
            pessoasDevoradas += collision.gameObject.GetComponent<Inimigo>().getValorInimigo();
            Destroy(collision.gameObject);
        }
    }
}
