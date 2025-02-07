using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompteRebour : MonoBehaviour
{
    [SerializeField] private float _activation = 0f;
    [SerializeReference] private GameObject _bille;
    [SerializeReference] private GameObject _terminus;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(_activation = 1f)
        {

        }
    }

    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Terminus")){
            _activation = 1f;
        }
    }
}
