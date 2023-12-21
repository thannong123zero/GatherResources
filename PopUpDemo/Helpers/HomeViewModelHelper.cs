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
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford 27 Shameless Màu Đỏ Gạch",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(12),
                Weight = "300g",
                Quantity = 200,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            }) ;
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford 24 Marocain Màu Đỏ Đất",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(14),
                Weight = "300g",
                Quantity = 500,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Gucci Màu 505 Janet Rust Matte Đỏ Đất Thời Thượng",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(20),
                Weight = "300g",
                Quantity = 600,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford Night Porter 38 Màu Đỏ Lạnh",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(9),
                Weight = "300g",
                Quantity = 20,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford Ruby Rush 07 Màu Đỏ Ruby",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(5),
                Weight = "300g",
                Quantity = 580,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford Flame 06 Màu Đỏ Cam",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(25),
                Weight = "300g",
                Quantity = 100,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Tom Ford Le Mepris 03 Màu Hồng Cam",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(14),
                Weight = "300g",
                Quantity = 920,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Louboutin Diva 505M Màu Đỏ Cam – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(16),
                Weight = "300g",
                Quantity = 480,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Louboutin Bengali 100M Màu Hồng Cánh Sen – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(24),
                Weight = "300g",
                Quantity = 320,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });
            productions.Add(new ProductionViewModel()
            {
                ID = Guid.NewGuid(),
                Name = "Son Louboutin 001M Rouge Louboutin Màu Đỏ Cổ Điển – Velvet Matte",
                Image = "https://lipstick.vn/wp-content/uploads/2020/06/son-tom-ford-27-247x300.jpg",
                Description = "Màu son xịn, đẹp tinh tế từ ngoại hình cho đến nội dung bên trong. Chất son vừa matte, vừa satin nên cực mướt, khiến môi ảo diệu bất ngờ với sắc đỏ gạch trendy.",
                Price = "999,999,000 Vnd",
                ManufacuturingDate = DateTime.Now.AddMonths(-12),
                ExpirationDate = DateTime.Now.AddMonths(26),
                Weight = "300g",
                Quantity = 250,
                CreateOn = DateTime.Now.AddMonths(-6),
                CreateBy = "Admin",
                UpdateOn = DateTime.Now.AddMonths(-6),
                UpdateBy = "Admin"
            });      
        }

        public List<ProductionViewModel> GetItems()
        {
            return productions;
        }
    }
}
