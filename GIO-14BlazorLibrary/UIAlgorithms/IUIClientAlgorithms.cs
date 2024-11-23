using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.UIAlgorithms
{
    public interface IUIClientAlgorithms
    {
        Task SetUpClientAsync(string authId, string emailAddress);
    }
}