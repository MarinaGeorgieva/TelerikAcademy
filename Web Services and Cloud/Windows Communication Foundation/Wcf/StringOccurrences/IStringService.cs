namespace StringOccurrences
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringService
    {
        [OperationContract]
        int CountOccurrences(string first, string second);      
    }    
}
