using System.Threading.Tasks;
using System.Xml.Linq;
using Fiap.Domain.Interfaces.DomainServices;
using Fiap.Domain.Interfaces.Https;
using Fiap.Domain.Validations;

namespace Fiap.Domain.Services {

    public class BlogService : IBlogService {

        private readonly BlogValidation _blogValidation;

        private readonly IBlogHttp _blogHttp;

        public BlogService (BlogValidation blogValidation, IBlogHttp blogHttp) {
            _blogValidation = blogValidation;
            _blogHttp = blogHttp;
        }

        public XElement LoadXml (string xmlRequest) {
            _blogValidation.ValidateXmlRequest (xmlRequest); // Fiz com parametro só para poder fazer uma regra de negócio
            XElement xmlResponse = _blogHttp.LoadXml (xmlRequest);
            _blogValidation.ValidateXmlResponse (xmlResponse);
            return xmlResponse;
        }
    }
}