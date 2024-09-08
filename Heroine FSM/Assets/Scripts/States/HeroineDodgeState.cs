using UnityEngine;

namespace Chapter.State
{
    public class HeroineDodgeState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            if (Input.GetKeyDown(KeyCode.A))
            {
                _heroineController.transform.localPosition += new Vector3(-0.5f, 0.2f, 0);
            } else if (Input.GetKeyDown(KeyCode.D))
            {
                _heroineController.transform.localPosition += new Vector3(0.5f, 0.2f, 0);
            }
        }
    }
}
