using Mango.Web.Models;
using Mango.Web.Models.Models;
using Mango.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _pServ;
        public ProductController(IProductService pServ)
        {
            _pServ = pServ;
        }


        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list = new();
            var response = await _pServ.GetAllProductsAsync<ResponseDto>();
            if (response == null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
