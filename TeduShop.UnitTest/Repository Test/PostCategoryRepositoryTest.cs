using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.UnitTest.Repository_Test
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork uniOfWork;

        // khởi tạo phương thức test
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            uniOfWork = new UnitOfWork(dbFactory);
        }
        //phương thức test
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll();
            Assert.AreEqual(8, list.Count());
        }


        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            // Mock Object - đối tượng giả lập dùng để test
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.CreatedDate = DateTime.Now;
            category.Status = true;

            var result = objRepository.Add(category);
            uniOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.ID);
        }
    }
}