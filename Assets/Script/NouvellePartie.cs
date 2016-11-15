using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace Assets.Script
{
    public class NouvellePartie : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void NewGame()
        {
//#if UNITY_EDITOR
            //UnityEngine.SceneManagement.SceneManager.LoadScene("Jeu");
            //UnityEngine.SceneManagement.SceneManager.UnloadScene("MenuPrincipale");

            SceneManager.LoadScene("Jeu");
            


//#endif
        }
    }

}

