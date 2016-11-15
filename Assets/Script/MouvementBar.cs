

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace Assets.Script
{

    public class MouvementBar : MonoBehaviour {

        // Déclaration de la variable de vitesse
        public float m_speed = 0.1f; // px/sec
        private bool _collisionDetected = false;
        private Vector3 movement;
       

        // Use this for initialization
        void Start ()
        {
            movement = new Vector3(0f, 0f, 0f);
        }
    
        // Update is called once per frame
        void Update ()
        {
            if (!_collisionDetected)
            {
                //transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                movement.x = 0f;

                // Récupération des touches gauche et droite
                if (Input.GetKey(KeyCode.LeftArrow) && !this._collisionDetected)  //43
                    movement.x -= m_speed;
                if (Input.GetKey(KeyCode.RightArrow) && !this._collisionDetected)
                    movement.x += m_speed;

                // On applique le mouvement à l'objet
                transform.position += movement;
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
