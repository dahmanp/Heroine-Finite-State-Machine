using UnityEngine;

namespace Chapter.State
{
    public class HeroineAcidTripState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            _heroineController.CurrentSpeed = 0;
        }
    }
}