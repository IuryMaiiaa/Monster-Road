using UnityEngine;
using System.Collections;

public class GerenciadorDeInimigos : MonoBehaviour {
    public SpawEnemy[] spawEnemies;
    public GameObject inimigoNivel1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
