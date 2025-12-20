using DmsApp.Web.Models.ViewModel;

namespace DmsApp.Web.Services
{
    public interface IMenuService
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem? GetById(int id);
        MenuItem Create(MenuItem item);
        bool Update(MenuItem item);
        bool Delete(int id);
        int NextId();
    }
}
