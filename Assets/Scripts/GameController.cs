using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebinKeys
{
    public class GameController : MonoBehaviour
    {
        public InputCommander inputCommonder;

        private Command rightCommand;  
        private Command leftCommand;
        private Command upCommand;
        private Command downCommand;

        private Stack<Command> undoCommands = new Stack<Command>();
        private Stack<Command> redoCommands = new Stack<Command>();

        //private 
    }
}