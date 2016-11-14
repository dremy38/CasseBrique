using UnityEngine;

namespace Assets.Script
{
    public class Destroy : MonoBehaviour {

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "PanelJeu")
                Debug.Log("colision");
        }
    }
}
