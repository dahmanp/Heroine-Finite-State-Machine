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
                _heroineController.Jump();
            }

            if (Input.GetKeyDown(KeyCode.S) && !_heroineController._isGrounded)
            {
                _heroineController.Dive();
            }

            if (Input.GetKeyDown(KeyCode.S) && _heroineController._isGrounded)
            {
                _heroineController.Duck();
            }

            if (Input.GetKeyDown(KeyCode.C) && _heroineController._isGrounded)
            {
                _heroineController.Cry();
            }

            if (Input.GetKeyDown(KeyCode.E) && _heroineController._isGrounded)
            {
                _heroineController.AcidTrip();
            }

            if (Input.GetKeyDown(KeyCode.A) && _heroineController._isGrounded)
            {
                _heroineController.Dodge();
            } else if (Input.GetKeyDown(KeyCode.D) && _heroineController._isGrounded)
            {
                _heroineController.Dodge();
            }

            if (Input.GetKeyUp(KeyCode.C) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Q))
            {
                _heroineController.Rest();
            }
        }
    }
}