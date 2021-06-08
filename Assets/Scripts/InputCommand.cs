namespace CommandPattern.RebinKeys
{
    public class InputCommand : Command
    {
        private InputCommander inputCommander;
        

        public InputCommand(InputCommander _commander)
        {
            this.inputCommander = _commander;
        }


        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}