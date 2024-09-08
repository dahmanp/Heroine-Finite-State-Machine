using UnityEngine;

namespace Chapter.State
{
    public class HeroineDuckState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;
            heroineController._isDucking = true;
            heroineController.transform.localScale = new Vector3(1, 0.5f, 1);
        }
    }
}