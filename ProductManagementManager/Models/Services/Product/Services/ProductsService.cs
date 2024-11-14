using AutoMapper;
using ProductManagementManager.Models.Repositories.Product.Entites;
using ProductManagementManager.Models.Repositories.Product.Repositories;
using ProductManagementManager.Models.Repositories.UnitOfWork;
using ProductManagementManager.Models.Services.Product.Dtos;
using System.Net;

namespace ProductManagementManager.Models.Services.Product.Services
{
    public class ProductsService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork) : IProductsService
    {
        public async Task<ServiceResult<ProductsDto>> Create(AddRequest request)
        {
            var hasProduct = productRepository.Where(x => x.Name == request.Name).Any();
            if (hasProduct)
            {
                return ServiceResult<ProductsDto>.Fail("Product already exists", HttpStatusCode.BadRequest);
            }
            var productToCreate = mapper.Map<ProductsEntity>(request);
            productRepository.Add(productToCreate);
            await unitOfWork.CommitAsync();
            var productDto = mapper.Map<ProductsDto>(productToCreate);
            return ServiceResult<ProductsDto>.Success(productDto, HttpStatusCode.Created);

        }

        public async Task<ServiceResult> Delete(int id)
        {
            var hasProduct = await productRepository.Get(id);
            if (hasProduct is null)
            {
                return ServiceResult.Fail("Product not found", HttpStatusCode.NotFound);
            }
            productRepository.Delete(hasProduct);
            await unitOfWork.CommitAsync();
            return ServiceResult.Success(HttpStatusCode.NoContent);
        }

        public async Task<ServiceResult<List<ProductsDto>>> Get()
        {
            var products = await productRepository.Get();
            var map = mapper.Map<List<ProductsDto>>(products);
            return ServiceResult<List<ProductsDto>>.Success(map, HttpStatusCode.OK);
        }

        public async Task<ServiceResult<ProductsDto>> Get(int id)
        {
            var product = await productRepository.Get(id);
            if (product is null)
            {
                return ServiceResult<ProductsDto>.Fail("Product not found", HttpStatusCode.NotFound);
            }
            var map = mapper.Map<ProductsDto>(product);

            return ServiceResult<ProductsDto>.Success(map, HttpStatusCode.OK);
        }

        public async Task<ServiceResult> Update(UpdateRequest request)
        {
            var productIdControl = await productRepository.Get(request.Id);
            if (productIdControl is null)
            {
                return ServiceResult.Fail("Product not found", HttpStatusCode.NotFound);
            }
            if (productIdControl != null)
            {
                productIdControl.Name = request.Name;
                productIdControl.Explain = request.Explain;
                productIdControl.Stock = request.Stock;
                productIdControl.Price = request.Price;
            }
            productRepository.Update(productIdControl);
            await unitOfWork.CommitAsync();
            return ServiceResult.Success(HttpStatusCode.NoContent);
        }
    }
}
