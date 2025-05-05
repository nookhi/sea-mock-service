using CoreWCF;
using Models;
using System.Threading.Tasks;

[ServiceContract]
public interface IDocumentService
{
    [OperationContract]
    Task<CreateDocumentResponse> createDocument(CreateDocumentRequest request);

    [OperationContract]
    Task<SetContentResponse> setContent(SetContentRequest request);

    [OperationContract]
    Task<GetContentResponse> getContent(GetContentRequest request);

    [OperationContract]
    Task<DeleteDocumentResponse> deleteDocument(DeleteDocumentRequest request);
}