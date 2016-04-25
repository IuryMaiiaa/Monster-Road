using UnityEngine;
using System.Collections;

public class GerenciadorDeInimigos : MonoBehaviour {
    public SpawEnemy[] spawEnemies;
    public GameObject inimigoNivel1;
    public int quantidadeDeInimigos;
    public float tempoContagem;
    public PlayerMonstro player;

	// Use this for initialization
	void Start () {
        tempoContagem = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        spawInimigoTimer();

    }

    public void spawInimigoTimer()
    {
        if(tempoContagem+10 > Time.time)
        {
            if(realizarContagemInimigosVivos() < 2)
            {

            }
            tempoContagem = Time.time;
        }
    }

    public void spawInimgio()
    {
        foreach(SpawEnemy enemySpaw in spawEnemies)
        {
            if(!enemySpaw.inimigoVivo())
            {
                enemySpaw.spawInimigo(getInimigoPrefab(player.pessoasDevoradas));
            }
        }
    }

    public int realizarContagemInimigosVivos()
    {
        int inimigos = 0;
        foreach(SpawEnemy enemy in spawEnemies)
        {
            if(enemy.inimigoVivo())
            {
                inimigos++;
            }
        }
        return inimigos;
    }

    public GameObject getInimigoPrefab(int lvPlayer)
    {
        
        return inimigoNivel1;
    }
}
