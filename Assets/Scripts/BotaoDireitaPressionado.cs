using UnityEngine;
using System.Collections;

public class BotaoDireitaPressionado : UnityEngine.UI.Button {

    UnityEngine.UI.Button botao;

    public bool botaoApertado;
    public float tempoPassado;
    public float tempoUpdate;

    // Use this for initialization
    void Start()
    {

        botaoApertado = false;
        tempoUpdate = 0.1f;
        tempoPassado = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tempoPassado + tempoUpdate && botaoApertado == true)
        {
            GameObject.FindObjectOfType<PlayerMonstro>().virarDireita();
            tempoPassado = Time.time;
        }
    }

    override
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        botaoApertado = true;
    }

    override
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        botaoApertado = false;
    }
}
