using System;


namespace R5T.O0008
{
    public class CodeFileGenerationOperations : ICodeFileGenerationOperations
    {
        #region Infrastructure

        public static ICodeFileGenerationOperations Instance { get; } = new CodeFileGenerationOperations();


        private CodeFileGenerationOperations()
        {
        }

        #endregion
    }
}
