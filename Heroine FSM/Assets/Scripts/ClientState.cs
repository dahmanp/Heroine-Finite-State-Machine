using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private HeroineController _heroineController;

        void Start()
        {
            _heroineController =
                (HeroineController)
                FindObjectOfType(typeof(HeroineController));
        }

        void OnGUI()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _heroineController._isGrounded)
            {
                Debug.Log("Jump");
                _heroineController.Jump();
            }

            if (Input.GetKeyDown(KeyCode.S) && !_heroineController._isGrounded)
            {
                Debug.Log("Dive");
                _heroineController.Dive();
            }

            if (Input.GetKeyDown(KeyCode.S) && _heroineController._isGrounded)
            {
                Debug.Log("Duck");
                _heroineController.Duck();
            }

            if (Input.GetKeyDown(KeyCode.C) && _heroineController._isGrounded)
            {
                Debug.Log("Cry");
                _heroineController.Cry();
            }

            if (Input.GetKeyDown(KeyCode.E) && _heroineController._isGrounded)
            {
                //FINISH
                Debug.Log("AcidTrip");
                _heroineController.AcidTrip();
            }

            if (Input.GetKeyDown(KeyCode.A) && _heroineController._isGrounded)
            {
                Debug.Log("Dodge");
                _heroineController.Dodge();
            } else if (Input.GetKeyDown(KeyCode.D) && _heroineController._isGrounded)
            {
                Debug.Log("Dodge");
                _heroineController.Dodge();
            }

            if (Input.GetKeyUp(KeyCode.C) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Q))
            {
                Debug.Log("Rest");
                _heroineController.Rest();
            }
        }
    }
}