using Moq;
using ProductsAPI.Domains;
using ProductsAPI.Interfaces;
using ProductsAPI.Repositories;

namespace testAPIxUnit.Test
{
    public class ProductsTest
    {
        [Fact]
        public void Get()
        {
            //lista de produtos
            List<Product> productList = new List<Product>
            {
                new Product {IdProduct = Guid.NewGuid(), Name="Produto 1", Price = 78},
                new Product { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Product { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }
            };

            //cria um objeto de simulacao do tipo ProductRepository
            var mockRepository = new Mock<IProductRepository>();

            //configura o metodo "Get" para quando for acionado retorne a lista de produtos mockada
            mockRepository.Setup(x => x.Get()).Returns(productList);

            //executando o método "Get" e atribui a resposta em "result"
            var result = mockRepository.Object.Get();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void Post()
        {
            List<Product> prodctList = new List<Product>();

            Product newProduct = new Product { IdProduct = Guid.NewGuid(), Name = "Produto1", Price = 40 };

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Post(newProduct)).Callback(new Action<Product>(x =>
            {
                prodctList.Add(newProduct);
            })).Verifiable();

            mockRepository.Object.Post(newProduct);

            mockRepository.Verify(x => x.Post(newProduct), Times.Once());

            Assert.Contains(newProduct, prodctList);
        }

        [Fact]
        public void GetById()
        {
            var id = Guid.NewGuid();

            var productList = new List<Product>
            {
                new Product { IdProduct = id,Name = "Produto1", Price = 500 },
            };

            var mockRepository = new Mock<IProductRepository>();

            var produto = productList.FirstOrDefault(x => x.IdProduct == id);

            mockRepository.Setup(x => x.GetById(id)).Returns(produto);


            var result = mockRepository.Object.GetById(id);


            Assert.Equal(produto, result);
        }
    }
}