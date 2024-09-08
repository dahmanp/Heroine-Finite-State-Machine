using UnityEngine;

namespace Chapter.State
{
    public class HeroineController : MonoBehaviour
    {
        public float jumpSpeed;
        public float fallSpeed;
        public AudioSource crying;
        public Material cry;
        public Material cube;
        public ParticleSystem tears;
        public Rigidbody rigidBody;
        public bool _isDucking = false;
        public bool _isGrounded
        {
            get { return Physics.Raycast(transform.position, -Vector3.up, 1f); }
        }
        //split
        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection
        {
            get; private set;
        }

        private IHeroineState
            _restState, _jumpState, _duckState, _diveState, _cryState, _acidTripState, _dodgeState;

        private HeroineStateContext _heroineStateContext;

        private void Start()
        {
            _heroineStateContext =
                new HeroineStateContext(this);

            _restState =
                gameObject.AddComponent<HeroineRestState>();
            _jumpState =
                gameObject.AddComponent<HeroineJumpState>();
            _duckState =
                gameObject.AddComponent<HeroineDuckState>();
            _diveState =
                gameObject.AddComponent<HeroineDiveState>();
            _cryState =
                gameObject.AddComponent<HeroineCryState>();
            _acidTripState =
                gameObject.AddComponent<HeroineAcidTripState>();
            _dodgeState =
                gameObject.AddComponent<HeroineDodgeState>();
        }

        public void Rest()
        {
            _heroineStateContext.Transition(_restState);
        }

        public void Jump()
        {
            _heroineStateContext.Transition(_jumpState);
        }

        public void Duck()
        {
            _heroineStateContext.Transition(_duckState);
        }

        public void Dive()
        {
            _heroineStateContext.Transition(_diveState);
        }

        public void Cry()
        {
            _heroineStateContext.Transition(_cryState);
        }

        public void Dodge()
        {
            if (_isDucking == true)
            {
                _heroineStateContext.Transition(_dodgeState);
            }
        }

        public void AcidTrip()
        {
            _heroineStateContext.Transition(_acidTripState);
        }
    }
}