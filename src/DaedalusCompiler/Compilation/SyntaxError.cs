namespace DaedalusCompiler.Compilation
{
    public partial class Compiler
    {
        public class SyntaxError
        {
            public string Message { get; set; }
            public int Line { get; set; }
            public int Column { get; set; }
        }
    }
}