using System.Threading.Tasks;
using System.Xml.Linq;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Application.Mappers;
using Fiap.Application.ViewModels;
using Fiap.Domain.Interfaces.DomainServices;

namespace Fiap.Application.AppServices {

    public class BlogAppService : IBlogAppService {

        private readonly IBlogService _blogService;

        private readonly BlogMapper _blogMapper;

        public BlogAppService (IBlogService blogService, BlogMapper blogMapper) {
            _blogService = blogService;
            _blogMapper = blogMapper;
        }

        public BlogViewModel ListTop10 (string xmlRequest) {
            XElement xmlResponse = _blogService.LoadXml (xmlRequest);
            BlogViewModel blog = _blogMapper.XmlElementToViewModel (xmlResponse);
            return blog;
        }
    }
}