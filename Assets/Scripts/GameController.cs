using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebinKeys
{
    public class GameController : MonoBehaviour
    {
        public InputCommander inputCommonder;

        [System.Serializable]
        public class KeyInputBinding
        {
            public KeyCode key;
            public InputCommand command;
        }

        public List<KeyInputBinding> keyInputCommands;

        private Stack<Command> undoCommands = new Stack<Command>();
        private Stack<Command> redoCommands = new Stack<Command>();

        private bool isReplaying = false;

        private void Start()
        {
            for (int i = 0; i < keyInputCommands.Count; i++)
            {
                keyInputCommands[i].command = new InputCommand(inputCommonder);
            }
        }
        private void Update()
        {
            if (isReplaying)
            {
                return;
            }
            for (int i = 0; i < keyInputCommands.Count; i++)
            {
                KeyInputBinding currentKeyBing = keyInputCommands[i];
                if (Input.GetKeyDown(currentKeyBing.key))
                {
                    ExcuteNewCommand(currentKeyBing.command);
                    break;
                }
            }

        }

        private void ExcuteNewCommand(Command _command)
        {
            _command.Execute();
            undoCommands.Push(_command);
            redoCommands.Clear(); //Remove all redo commands redo is note defined when having a new command.
        }
    }
}