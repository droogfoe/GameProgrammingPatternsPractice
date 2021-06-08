using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace CommandPattern.RebinKeys
{
    public class InputCommander : MonoBehaviour
    {
        [SerializeField]
        [Range(0, 0.35f)]
        private float moveDuration;

        public void Execute(InputCommand.Type _type)
        {
            switch (_type)
            {
                case InputCommand.Type.MoveForward:
                    transform.DOBlendableMoveBy(Vector3.forward, moveDuration);
                    break;
                case InputCommand.Type.MoveBackward:
                    transform.DOBlendableMoveBy(Vector3.back, moveDuration);
                    break;
                case InputCommand.Type.MoveRight:
                    transform.DOBlendableMoveBy(Vector3.right, moveDuration);
                    break;
                case InputCommand.Type.MoveLeft:
                    transform.DOBlendableMoveBy(Vector3.left, moveDuration);
                    break;
            }
        }
        public void Undo(InputCommand.Type _type)
        {
            switch (_type)
            {
                case InputCommand.Type.MoveForward:
                    transform.DOBlendableMoveBy(Vector3.back, moveDuration);
                    break;
                case InputCommand.Type.MoveBackward:
                    transform.DOBlendableMoveBy(Vector3.forward, moveDuration);
                    break;
                case InputCommand.Type.MoveRight:
                    transform.DOBlendableMoveBy(Vector3.left, moveDuration);
                    break;
                case InputCommand.Type.MoveLeft:
                    transform.DOBlendableMoveBy(Vector3.right, moveDuration);
                    break;
            }
        }
    }
}