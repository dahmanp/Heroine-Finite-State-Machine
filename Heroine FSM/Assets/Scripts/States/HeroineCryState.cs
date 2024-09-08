using UnityEngine;

namespace Chapter.State
{
    public class HeroineCryState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            _heroineController.GetComponent<MeshRenderer>().material = _heroineController.cry;
            _heroineController.crying.Play();
            _heroineController.tears.Play();
        }
    }
}