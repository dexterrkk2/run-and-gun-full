using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject GameOverUi;
        public Rigidbody rb;
        public float maxSpeed = 2f;
        public float turnDistance = 2f;
        public float duckTime = .2f;
        public float jumpMod = 2;
        public float lastState;
        public float standingTimer;
        public float diveBombMod = 100;
        public bool grounded = false;
        public bool isDiving = false;
        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection
        {
            get; private set;
        }
        private IPlayerState
            _startState, _stopState, _turnState, _jumpState, _duckState, _diveBombState, _runState, _deathState, _superJump;
        private PlayerStateContext playerStateContext;
        // Start is called before the first frame update
        void Start()
        {
            lastState = 0;
            playerStateContext = new PlayerStateContext(this);
            _startState = gameObject.AddComponent<StartState>();
            _runState = gameObject.AddComponent<RunState>();
            _stopState = gameObject.AddComponent<StopState>();
            _turnState = gameObject.AddComponent<TurnState>();
            _jumpState = gameObject.AddComponent<StateJump>();
            _duckState = gameObject.AddComponent<DuckState>();
            _diveBombState = gameObject.AddComponent<DiveBomb>();
            _deathState = gameObject.AddComponent<DeathState>();
            _superJump = gameObject.AddComponent<SuperJump>();
            playerStateContext.Transition(_startState);
        }
        public void Standing()
        {
            playerStateContext.Transition(_startState);
        }
        public void Run()
        {
            playerStateContext.Transition(_runState);
        }
        public void Stop()
        {
            playerStateContext.Transition(_stopState);
        }
        public void Turn(Direction direction)
        {
            CurrentTurnDirection = direction;
            playerStateContext.Transition(_turnState);
        }
        public void Jump()
        {
            playerStateContext.Transition(_jumpState);
        }
        public void Duck()
        {
            playerStateContext.Transition(_duckState);
        }
        public void DiveBomb()
        {
            playerStateContext.Transition(_diveBombState);
        }
        public void Death()
        {
            playerStateContext.Transition(_deathState);
        }
        public void SuperJump()
        {
            playerStateContext.Transition(_superJump);
        }
        private void Update()
        {
            lastState += Time.deltaTime;
        }
    }
}
