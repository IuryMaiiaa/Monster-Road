using UnityEngine;
using System.Collections;

public class GerenciadorConstrucoes : MonoBehaviour {
    public spawContrucao[] contrucoes;
    public GameObject construcaoNivel1;
    public int quantidadeConstrucoes;
    public float tempoContagem;
    public PlayerMonstro player;

    // Use this for initialization
    void Start () {
	
	}

    void Update()
    {
        spawInimigoTimer();

    }

    public void spawInimigoTimer()
    {
        if (Time.time > tempoContagem + 10)
        {
            if (realizarContagemConstrucoesAtivas() < 2)
            {
                spawConstrucao();
            }
            tempoContagem = Time.time;
        }
    }

    public void spawConstrucao()
    {
        foreach (spawContrucao contrucaoSpaw in contrucoes)
        {
            if (!contrucaoSpaw.contrucaoAtiva())
            {
                contrucaoSpaw.spawConstrucao(getContrucaoPrefab(player.pessoasDevoradas));
            }
        }
    }

    public int realizarContagemConstrucoesAtivas()
    {
        int construcoesAtivas = 0;
        foreach (spawContrucao contrucaoSpaw in contrucoes)
        {
            if (contrucaoSpaw.contrucaoAtiva())
            {
                construcoesAtivas++;
            }
        }
        return construcoesAtivas;
    }

    public GameObject getContrucaoPrefab(int lvPlayer)
    {
        return construcaoNivel1;
    }
}
