namespace CSP.PluralSight.CollectionsGenerics.Generics.GenericCode
{
    /// <summary>
    /// Provides a success flag and message useful as a method return type.
    /// </summary>
    public class OperationResult
    {
        #region Constructors
        public OperationResult() { }

        public OperationResult(bool result, string message)
        {
            Result = result;
            Message = message;
        }
        #endregion

        #region Properties
        public bool Result { get; set; }
        public string Message { get; set; }
        #endregion
    }
}
