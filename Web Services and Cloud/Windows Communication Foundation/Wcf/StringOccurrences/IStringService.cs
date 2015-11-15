namespace StringOccurrences
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringService
    {
        [OperationContract]
        int CountOccurrences(string firstString, string secondString);      
    }    
}
