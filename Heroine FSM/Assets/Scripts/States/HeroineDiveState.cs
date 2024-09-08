using UnityEngine;

namespace Chapter.State
{
    public class HeroineDiveState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            heroineController.rigidBody.AddForce(Vector3.down * _heroineController.fallSpeed, ForceMode.Impulse);
        }
    }
}