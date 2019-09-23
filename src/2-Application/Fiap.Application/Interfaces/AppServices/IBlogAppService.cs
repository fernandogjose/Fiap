using Fiap.Application.ViewModels;
using System.Threading.Tasks;

namespace Fiap.Application.Interfaces.AppServices
{
    public interface IBlogAppService
    {
        BlogViewModel ListTop10(string xml);
    }
}
