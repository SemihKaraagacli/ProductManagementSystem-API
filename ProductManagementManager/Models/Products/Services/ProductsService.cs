using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using ProductManagementManager.Models.Products.Dtos;
using ProductManagementManager.Models.Products.Entites;
using ProductManagementManager.Models.Products.Repositories;
using System.Net;

namespace ProductManagementManager.Models.Products.Services
{
    public class ProductsService(IProductRepository productRepository, IMapper mapper) : IProductsService
    {
        public ServiceResult<ProductsDto> Create(AddRequest request)
        {
            var hasProduct = productRepository.Get().Where(x => x.Name == request.Name).Any();
            if (hasProduct)
            {
                return ServiceResult<ProductsDto>.Fail("Product already exists", HttpStatusCode.BadRequest);
            }
            var productCount = productRepository.Get().Count;
            var newProduct = new ProductsEntity();
            newProduct.Id = productCount + 1;
            newProduct.Explain = request.Explain;
            newProduct.Name = request.Name;
            newProduct.Price = request.Price;
            newProduct.Stock = request.Stock;
            productRepository.Create(newProduct);
            var map = mapper.Map<ProductsDto>(newProduct);
            return ServiceResult<ProductsDto>.Success(map, HttpStatusCode.Created);

        }

        public ServiceResult Delete(int id)
        {
            var hasProduct = productRepository.GetByID(id);
            if (hasProduct is null)
            {
                return ServiceResult.Fail("Product not found", HttpStatusCode.NotFound);
            }
            productRepository.Delete(id);
            return ServiceResult.Success(HttpStatusCode.NoContent);
        }

        public ServiceResult<List<ProductsDto>> Get()
        {
            var products = productRepository.Get();
            var map = mapper.Map<List<ProductsDto>>(products);
            return ServiceResult<List<ProductsDto>>.Success(map, HttpStatusCode.OK);
        }

        public ServiceResult<ProductsDto> Get(int id)
        {
            var product = productRepository.GetByID(id);
            if (product is null)
            {
                return ServiceResult<ProductsDto>.Fail("Product not found", HttpStatusCode.NotFound);
            }
            var map = mapper.Map<ProductsDto>(product);

            return ServiceResult<ProductsDto>.Success(map, HttpStatusCode.OK);
        }

        public ServiceResult Update(UpdateRequest request)
        {
            var productIdControl = productRepository.GetByID(request.Id);
            if (productIdControl is null)
            {
                return ServiceResult.Fail("Product not found", HttpStatusCode.NotFound);
            }
            var newProduct = new ProductsEntity();
            newProduct.Id = request.Id;
            newProduct.Name = request.Name;
            newProduct.Price = request.Price;
            newProduct.Explain = request.Explain;
            newProduct.Stock = request.Stock;
            productRepository.Update(newProduct);
            return ServiceResult.Success(HttpStatusCode.NoContent);
        }
    }
}
