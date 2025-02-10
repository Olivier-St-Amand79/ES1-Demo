using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompteRebour : MonoBehaviour
{
    private float _activation = 0;
    [SerializeReference] private GameObject _bille;
    [SerializeReference] private GameObject _terminus;
    public double countdownTime = 5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(_activation == 1)
        {
          string nomSceneActuel = SceneManager.GetActiveScene().name;
          SceneManager.LoadScene(nomSceneActuel);
        }
         
    }

    void OnCollisionEnter(Collision collision){
          print(collision.gameObject.name + " : " + collision.gameObject.tag);
          if(collision.gameObject.CompareTag("Terminus")){
               _activation += 1;
            }
    }  
}
