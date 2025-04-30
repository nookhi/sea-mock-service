using System;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract(Namespace = "http://ws.ustorage.idmt.ru")]
public interface IDocumentServicePort
{
    [OperationContract]
    getDocumentResponse getDocument(getDocument request);

    [OperationContract]
    getVersionsResponse getVersions(getVersions request);
}

[DataContract(Namespace = "http://ws.ustorage.idmt.ru")]
public class getDocument
{
    [DataMember]
    public string documentId { get; set; }
}

[DataContract(Namespace = "http://ws.ustorage.idmt.ru")]
public class getDocumentResponse
{
    [DataMember]
    public string result { get; set; } = "Mocked Document Content";
}

[DataContract(Namespace = "http://rt.fs.documentum.emc.com/")]
public class getVersions
{
    [DataMember]
    public string documentId { get; set; }
}

[DataContract(Namespace = "http://rt.fs.documentum.emc.com/")]
public class getVersionsResponse
{
    [DataMember]
    public string[] versions { get; set; } = new[] { "v1", "v2" };
}

public class DocumentService : IDocumentServicePort
{
    public getDocumentResponse getDocument(getDocument request)
    {
        Console.WriteLine($"getDocument called with ID: {request.documentId}");
        return new getDocumentResponse();
    }

    public getVersionsResponse getVersions(getVersions request)
    {
        Console.WriteLine($"getVersions called for document: {request.documentId}");
        return new getVersionsResponse();
    }
}
