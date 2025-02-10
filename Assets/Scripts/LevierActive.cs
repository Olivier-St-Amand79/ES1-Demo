using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevierActive : MonoBehaviour


{
    [SerializeReference] private GameObject _platformePassage;

    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Levier")){
            Destroy(_platformePassage);
        }
    }
}
