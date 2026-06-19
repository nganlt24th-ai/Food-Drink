using Core.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Models.EF
{
    public class FoodContext: DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group()
                {
                    Id = Guid.Parse("2BD8BD81-F341-438A-98FB-DFAD4FFD15BC"),
                    Name = "Quản trị viên"
                }
                );
            modelBuilder.Entity<Member>().HasData(
                new Member()
                {
                    Id = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                    Name ="Thanh Ngân",
                    Picture = "/img/users/tn.jpg",
                    LoginName = "thanh.ngan",
                    Password = "c81e728d9d4c2f636f067f89cc14862c",
                    Email = "nganlt.24th@sv.dla.edu.vn",
                    CreatedOn = DateTime.Now,
                    GroupId = Guid.Parse("2BD8BD81-F341-438A-98FB-DFAD4FFD15BC")

                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.Parse("F4FAE31D-33FA-46F5-95D2-5339A77676A7"),
                    Name = "Root",
                    CreatedBy = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                    CreatedOn = DateTime.Now
                },
                 new Category()
                 {
                     Id = Guid.Parse("EC6A9BF5-545D-4F1A-B288-A0F54D928193"),
                     Name = "Authorized",
                     CreatedBy = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("F4FAE31D-33FA-46F5-95D2-5339A77676A7")
                 }, new Category()
                 {
                     Id = Guid.Parse("9ECA7EB7-A450-431A-A071-AD472E358A24"),
                     Name = "Nhóm quyền",
                     CreatedBy = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("EC6A9BF5-545D-4F1A-B288-A0F54D928193")
                 },
                 new Category()
                 {
                     Id = Guid.Parse("5AE4A4F8-B62F-427F-8987-E1CAEC355C6F"),
                     Name = "New",
                     CreatedBy = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("F4FAE31D-33FA-46F5-95D2-5339A77676A7")
                 },
                 new Category()
                 {
                     Id = Guid.Parse("38CD1E1D-D162-40B3-A543-DE7FD5398253"),
                     Name = "Menu",
                     CreatedBy = Guid.Parse("E3FA3F30-1996-44FC-A68F-941C808E7394"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("F4FAE31D-33FA-46F5-95D2-5339A77676A7")
                 }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = Guid.Parse("5A8AFD30-F4E8-4F8D-8519-D27FE14C2EEE"),
                    Name = "Xem danh sách",
                    Code = "view-groups",
                    CategoryId = Guid.Parse("9ECA7EB7-A450-431A-A071-AD472E358A24")
                }, new Role()
                {
                    Id = Guid.Parse("BE6B8A79-BF82-4F30-B470-346CBE1A82CB"),
                    Name = "Cập nhật",
                    Code = "edit-group",
                    CategoryId = Guid.Parse("9ECA7EB7-A450-431A-A071-AD472E358A24")
                }, new Role()
                {
                    Id = Guid.Parse("927793D2-F9E3-449D-BCF5-851702B8B355"),
                    Name = "Lưu",
                    Code = "save-group",
                    CategoryId = Guid.Parse("9ECA7EB7-A450-431A-A071-AD472E358A24")
                }, new Role()
                {
                    Id = Guid.Parse("69DB046A-0465-45DE-994D-0901CD9286BB"),
                    Name = "Xóa",
                    Code = "delete-group",
                    CategoryId = Guid.Parse("9ECA7EB7-A450-431A-A071-AD472E358A24")
                }
                );
            modelBuilder.Entity<Authorized>().HasData(
                new Authorized()
                {
                    Id = Guid.NewGuid(),
                    GroupId = Guid.Parse("2BD8BD81-F341-438A-98FB-DFAD4FFD15BC"),
                    RoleId = Guid.Parse("5A8AFD30-F4E8-4F8D-8519-D27FE14C2EEE")
                }
                );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<New> News { get; set; }
        public DbSet<Authorized> Authorizeds { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Details> Details { get; set; }


    }
}
