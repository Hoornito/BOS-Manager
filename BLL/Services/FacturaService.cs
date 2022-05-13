using Contratos.Repositories;
using Contratos.Services;

using Domain.Models;

using SL.Tools;

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FacturaService : GenericService<FacturaModel>, IFacturaService
    {
        public FacturaService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IFacturaRepository>())
        {

        }


        public void CrearFactura(FacturaModel facturaModel)
        {
            try
            {
                var _pedidoRepository = _unitOfWork.GetRepository<IPedidoRepository>();
                var pedido = _pedidoRepository.GetById(facturaModel.Id_Pedido);
                facturaModel.BaseImponible = (Convert.ToDecimal(pedido.Total) / (1 + facturaModel.IVA)).ToString();
                facturaModel.IVADiscriminado = (Convert.ToDecimal(facturaModel.BaseImponible) * facturaModel.IVA).ToString();
                facturaModel.FechaYHora = DateTime.Now;

                Insertar(facturaModel);

                pedido.Estado = "Facturado";
                _pedidoRepository.Update(pedido);

                _unitOfWork.Save();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
