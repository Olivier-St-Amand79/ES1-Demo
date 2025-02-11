using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompteRebour : MonoBehaviour
{
    float temps = 0;
    private float _activation = 0;
    [SerializeReference] private GameObject _bille;
    [SerializeReference] private GameObject _terminus;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(_activation == 1)
        {
          temps += Time.deltaTime;
          Debug.Log(temps);

          if(temps > 5)
          {
            string nomSceneActuel = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(nomSceneActuel);
          }
        }   
    }

    /*void Redemarrage()
    {
       if(temps == 5f)
          {
            
          }
    }*/

    

    void OnCollisionEnter(Collision collision){
          print(collision.gameObject.name + " : " + collision.gameObject.tag);
          if(collision.gameObject.CompareTag("Terminus")){
               _activation += 1;
            }
    }  
}
