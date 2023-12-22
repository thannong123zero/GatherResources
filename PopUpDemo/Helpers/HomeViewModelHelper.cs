using PopUpDemo.Models;

namespace PopUpDemo.Helpers
{
    public class HomeViewModelHelper
    {
        private List<ProductionViewModel> productions;

        public HomeViewModelHelper()
        {
            productions = new List<ProductionViewModel>();

            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford 27 Shameless Màu Đỏ Gạch",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(12),
                Weight = "300g",
                Quantity = 200
            }) ;
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford 24 Marocain Màu Đỏ Đất",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(14),
                Weight = "300g",
                Quantity = 500
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Gucci Màu 505 Janet Rust Matte Đỏ Đất Thời Thượng",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(20),
                Weight = "300g",
                Quantity = 600
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford Night Porter 38 Màu Đỏ Lạnh",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(9),
                Weight = "300g",
                Quantity = 20
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford Ruby Rush 07 Màu Đỏ Ruby",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(5),
                Weight = "300g",
                Quantity = 580
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford Flame 06 Màu Đỏ Cam",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(25),
                Weight = "300g",
                Quantity = 100
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Tom Ford Le Mepris 03 Màu Hồng Cam",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(14),
                Weight = "300g",
                Quantity = 920
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Louboutin Diva 505M Màu Đỏ Cam – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(16),
                Weight = "300g",
                Quantity = 480
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Louboutin Bengali 100M Màu Hồng Cánh Sen – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(24),
                Weight = "300g",
                Quantity = 320
            });
            productions.Add(new ProductionViewModel()
            {
                Name = "Son Louboutin 001M Rouge Louboutin Màu Đỏ Cổ Điển – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(26),
                Weight = "300g",
                Quantity = 250
            });      
        }
        public List<ProductionViewModel> GetItems()
        {
            return productions;
        }
        public ProductionViewModel GetItemByID(Guid id)
        {
            ProductionViewModel production = productions.Where(s => s.ID == id).FirstOrDefault();
            if(production != null)
            {
                return production;
            }
            return null;
        }
        public bool AddItem(ProductionViewModel model)
        {
            productions.Add(model);
            return true;
        }
        public bool DeleteItemByID(Guid id)
        {
            int temp = productions.RemoveAll(s => s.ID == id);
            if(temp != 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateItem(ProductionViewModel model)
        {
            ProductionViewModel production = productions.Where(s => s.ID == model.ID).FirstOrDefault();
            if (production == null)
            {
                return false;
            }

            production.Name = model.Name;
            production.Image = model.Image;
            production.Price = model.Price;
            production.Quantity = model.Quantity;
            production.Weight = model.Weight;
            production.ExpirationDate = model.ExpirationDate;
            production.ManufacuturingDate = model.ManufacuturingDate;
            production.UpdatedOn = DateTime.Now;
            return true;
        }
    }
}
