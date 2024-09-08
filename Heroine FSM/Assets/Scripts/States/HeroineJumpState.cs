using UnityEngine;

namespace Chapter.State
{
    public class HeroineJumpState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            Ray ray = new Ray(transform.position, Vector3.down);
            if (Physics.Raycast(ray, 0.7f))
                heroineController.rigidBody.AddForce(Vector3.up * _heroineController.jumpSpeed, ForceMode.Impulse);
        }
    }
}