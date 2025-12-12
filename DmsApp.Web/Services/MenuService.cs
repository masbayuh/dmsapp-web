using DmsApp.Web.Models;

namespace DmsApp.Web.Services
{
    public class MenuService : IMenuService
    {
        private readonly List<MenuItem> _items;

        public MenuService()
        {
            _items = new List<MenuItem>
            {
                new MenuItem {
                    Id = 1,
                    MenuName = "User Management",
                    MenuCode = "UM-001",
                    Description = "Manage users, roles and permissions",
                    LastUpdate = new DateTime(2025, 11, 28),
                    PIC = "Rizal",
                    Version = "1.2.0",
                    Module = "Admin",
                    Status = "Released",
                    Notes = "Stabilized release"
                },
                new MenuItem {
                    Id = 2,
                    MenuName = "Reporting Dashboard",
                    MenuCode = "RD-002",
                    Description = "Visual dashboard for KPI and metrics",
                    LastUpdate = new DateTime(2025, 12, 05),
                    PIC = "Siti",
                    Version = "0.9.3",
                    Module = "Analytics",
                    Status = "Beta",
                    Notes = "Requires dataset sync"
                },
                new MenuItem {
                    Id = 3,
                    MenuName = "Order Processing",
                    MenuCode = "OP-003",
                    Description = "End-to-end order workflow",
                    LastUpdate = DateTime.UtcNow.Date,
                    PIC = "Agus",
                    Version = "2.0.1",
                    Module = "Sales",
                    Status = "Released",
                    Notes = "Performance improvements"
                }
            };
        }

        public MenuItem Create(MenuItem item)
        {
            item.Id = NextId();
            _items.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            var item = GetById(id);
            if (item == null)
                return false;
            return _items.Remove(item);
        }

        public IEnumerable<MenuItem> GetAll() => _items.OrderBy(i => i.MenuName);

        public MenuItem? GetById(int id) => _items.FirstOrDefault(i => i.Id == id);

        public int NextId() => _items.Any() ? _items.Max(i => i.Id) + 1 : 1;

        public bool Update(MenuItem item)
        {
            var idx = _items.FindIndex(i => i.Id == item.Id);
            if (idx == -1)
                return false;
            _items[idx] = item;
            return true;
        }
    }
}
