using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class TurnState: MonoBehaviour, IPlayerState
    {
        private Vector3 _turnDirection;
        private PlayerController _playerController;
        public void Handle(PlayerController bikeController)
        {
            if (!_playerController)
            {
                _playerController = bikeController;
            }
            _turnDirection.x = (float)_playerController.CurrentTurnDirection;
            if(bikeController.CurrentSpeed > 0)
            {
                transform.Translate(_turnDirection * _playerController.turnDistance);
            }
        }
    }
}
