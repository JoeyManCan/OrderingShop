using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces;
using OrderingShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<bool> CreateProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public Task<ProductDto?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
