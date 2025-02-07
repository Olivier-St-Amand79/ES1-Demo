using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commencer : MonoBehaviour


{
    [SerializeReference] private GameObject _platformeInitiale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CommencerBouton()
    {
        _platformeInitiale.SetActive(false);
    }
}
