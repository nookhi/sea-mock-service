using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class DocumentService : IDocumentService
    {
        private static readonly Dictionary<string, DmrContent> _contentStore = new();

        public Task<CreateDocumentResponse> createDocument(CreateDocumentRequest request)
        {
            var response = new CreateDocumentResponse
            {
                @return = request.document
            };

            return Task.FromResult(response);
        }

        public Task<SetContentResponse> setContent(SetContentRequest request)
        {
            _contentStore[request.documentId] = request.content;

            var response = new SetContentResponse
            {
                @return = "OK"
            };

            return Task.FromResult(response);
        }

        public Task<GetContentResponse> getContent(GetContentRequest request)
        {
            if (_contentStore.TryGetValue(request.documentId, out var content))
            {
                var response = new GetContentResponse
                {
                    @return = content
                };

                return Task.FromResult(response);
            }

            return Task.FromResult(new GetContentResponse());
        }

        public Task<DeleteDocumentResponse> deleteDocument(DeleteDocumentRequest request)
        {
            _contentStore.Remove(request.documentId);

            return Task.FromResult(new DeleteDocumentResponse());
        }
    }
}