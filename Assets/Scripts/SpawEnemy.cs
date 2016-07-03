using UnityEngine;
using System.Collections;

public class SpawEnemy : MonoBehaviour {
    public GameObject inimigo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawInimigo(GameObject inimigo)
    {
        this.inimigo = GameObject.Instantiate(inimigo) as GameObject;
        this.inimigo.transform.position = new Vector3(this.transform.position.x,
                                                 this.transform.position.y + 2,
                                                 this.transform.position.z);
    }

    public bool inimigoVivo()
    {
        if(inimigo == null)
        {
            return false;
        }
        return true;
    }
}
