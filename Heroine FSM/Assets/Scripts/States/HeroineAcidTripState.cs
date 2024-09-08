using UnityEngine;
using System.Collections;

namespace Chapter.State
{
    public class HeroineAcidTripState : MonoBehaviour, IHeroineState
    {
        private HeroineController _heroineController;

        public void Handle(HeroineController heroineController)
        {
            if (!_heroineController)
                _heroineController = heroineController;

            _heroineController.GetComponent<MeshRenderer>().material = _heroineController.acidtrip;
            _heroineController.floor.GetComponent<MeshRenderer>().material = _heroineController.acidtrip;
            _heroineController.floor.GetComponent<Rotation>().enabled = true;
            _heroineController.sky.SetActive(true);
            heroineController.transform.localScale = new Vector3(3, 2, 2);
            _heroineController.tripping.Play();
        }
    }
}