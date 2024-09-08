using UnityEngine;

namespace Chapter.State
{
    public class HeroineRestState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            _heroineController.crying.Stop();
            _heroineController.tears.Stop();
            _heroineController.GetComponent<MeshRenderer>().material = _heroineController.cube;
            _heroineController.transform.localScale = new Vector3(1, 1, 1);
            _heroineController._isDucking = false;
        }
    }
}
