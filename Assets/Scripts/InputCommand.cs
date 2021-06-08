namespace CommandPattern.RebinKeys
{
    public class InputCommand : Command
    {
        private InputCommander inputCommander;
        public enum Type
        {
            MoveForward,
            MoveBackward,
            MoveRight,
            MoveLeft
        }
        private Type type;
        

        public InputCommand(InputCommander _commander, Type _type)
        {
            this.inputCommander = _commander;
            this.type = _type;
        }


        public override void Execute()
        {
            inputCommander.Execute(type);
        }

        public override void Undo()
        {
            inputCommander.Undo(type);
        }
    }
}