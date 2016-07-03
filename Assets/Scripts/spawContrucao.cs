using UnityEngine;
using System.Collections;

public class spawContrucao : MonoBehaviour {
    GameObject construcao;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawConstrucao(GameObject construcao)
    {
        this.construcao = GameObject.Instantiate(construcao) as GameObject;
        this.construcao.transform.position = new Vector3(this.transform.position.x,
                                                         this.transform.position.y + 2,
                                                         this.transform.position.z);
    }

    public bool contrucaoAtiva()
    {
        if (construcao == null)
        {
            return false;
        }
        return true;
    }
}
