using AutoMapper;

using Contratos.Controllers;
using Contratos.Services;

using Domain.Entities;
using Domain.Models;

using Microsoft.EntityFrameworkCore;

using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.Validators;

namespace UI.Controllers
{
    public class FacturaController : IFacturaController
    {
        IMapper _mapper;
        IFacturaService _facturaService;


        public FacturaController(IMapper mapper, IFacturaService facturaService)
        {
            _mapper = mapper;
            _facturaService = facturaService;
        }

        [ViewValidator]
        public void GuardarCambios(FacturaEntity facturaEntity)
        {
            //dependiendo del estado - ABM
            try
            {
                //Convierto el objeto de vista al objeto de transporte DTO
                var facturaDTO = _mapper.Map<FacturaModel>(facturaEntity);

                switch (facturaEntity.State)
                {
                    case EntityState.Added:
                        _facturaService.CrearFactura(facturaDTO);
                        var nroFactura = _facturaService.ObtenerUltimaFactura().Id_Factura;
                        LoggerManager.Info($"Factura #{nroFactura} generada correctamente.");
                        break;

                    case EntityState.Modified:
                        
                        break;

                    case EntityState.Deleted:

                        break;
                }

                facturaEntity.State = EntityState.Unchanged;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
