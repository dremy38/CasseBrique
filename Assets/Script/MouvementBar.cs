

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace Assets.Script
{

    public class MouvementBar : MonoBehaviour {

        // Déclaration de la variable de vitesse
        public float m_speed = 0.1f;
        private bool _collisionDetected = false;
        private Vector3 move;
       

        // Use this for initialization
        void Start ()
        {
            
        }
    
        // Update is called once per frame
        void Update ()
        {
            if (!_collisionDetected)
            {
                transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                move = new Vector3();

                // Récupération des touches gauche et droite
                if (Input.GetKey(KeyCode.LeftArrow) && !this._collisionDetected)  //43
                    move.x -= m_speed;
                if (Input.GetKey(KeyCode.RightArrow) && !this._collisionDetected)
                    move.x += m_speed;

                // On applique le mouvement à l'objet
                transform.position += move;
                //Debug.Log(transform.position.x); 
            }
           


        }
        void OnTriggerEnter(Collider col)
        {
            //Si le name du gameObject du collider touché est égale à "Player"

            if (col.name == "PanelJeu")
            {

               

            }



        }

        void OnTriggerExit(Collider col)
        {
            if (col.name == "PanelJeu")
            {

                


            }
        }
      



    }
}
