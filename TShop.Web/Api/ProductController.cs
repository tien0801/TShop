using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TShop.Model.Models;
using TShop.Service;
using TShop.Web.Infrastructure.Core;
using TShop.Web.Models;

namespace TShop.Web.Api
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiControllerBase
    {
        private IProductService _ProductService;

        public ProductController(IErrorService errorService, IProductService ProductService)
            : base(errorService)
        {
            this._ProductService = ProductService;
        }

        [Route("getall")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _ProductService.GetAll();
                var responseData = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }
    }
}