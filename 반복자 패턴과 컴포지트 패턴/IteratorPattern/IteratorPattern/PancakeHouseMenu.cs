using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems { get; private set; } = new List<MenuItem>();
        public PancakeHouseMenu()
        {
            AddItem("K&B 팬케이크 세트", "스크램블 에그와 토스트가 곁들여진 팬케이크", true, 2.99d);
            AddItem("레귤러 팬케이크 세트", "달걀 프라이와 소시기자 곁들여진 팬케이크", true, 2.99d);
            AddItem("", "", true, 2.99d);
            AddItem("", "", true, 2.99d);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItems.Add(new MenuItem(name, description, vegetarian, price));
        }
    }
}
