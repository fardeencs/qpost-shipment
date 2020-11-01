
namespace WebAPI.Controllers.PartnerOrder
{
    using DAL.Data.UnitOfWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using DAL.Data.DBContexts;
    using System.Threading.Tasks;

    [RoutePrefix("shipment/partner")]
    public class PartnerOrderController : ApiController
    {
        private readonly IUnitOfWork<MAC2000Context> _unitOfWork;

        public PartnerOrderController(IUnitOfWork<MAC2000Context> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("orders")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetPartnerOrders(int partnerId)
        {
            var data =  _unitOfWork.PartnerOrderRepository.GetPartnerOrders(partnerId);
            return Request.CreateResponse(HttpStatusCode.Found, data);
        }
        [Route("order")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetPartnerOrder()
        {
            var data = await _unitOfWork.PartnerOrderRepository.GetAllAsync();
            return Request.CreateResponse(HttpStatusCode.Found, data);
        }
    }
}
