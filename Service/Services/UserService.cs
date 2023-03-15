using Repository.Repositories;

namespace Service.Services
{
    public class UserService
    {
        private readonly UserRepository _productRepository;

        public UserService(UserRepository produtoRepository)
        {
            _productRepository = produtoRepository;
        }

        public IList<Product> GetAll()
        {
            var products = _productRepository.GetAll();

            return products.ToList();
        }

        public object GetById(long id)
        {
            var product = _productRepository.Find(id);

            return product;
        }

        public void Save(Product product)
        {
            _productRepository.Save(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(long id)
        {
            _productRepository.Delete(x => x.Id == id);
        }
    }
}