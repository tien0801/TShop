using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TShop.Model.Models;
using TShop.Service;
using TShop.Web.Infrastructure.Core;
using TShop.Web.Models;

namespace TShop.Web.Api
{
    [RoutePrefix("api/ProductCategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryService _ProductCategoryService;

        public ProductCategoryController(IErrorService errorService, IProductCategoryService ProductCategoryService)
            : base(errorService)
        {
            this._ProductCategoryService = ProductCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _ProductCategoryService.GetAll();
                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }
    }
}
