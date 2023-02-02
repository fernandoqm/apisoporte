using FluentValidation;
using SP.Application.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Application.Validators.ColaAtencion
{
    //Hacer las validaciones de los campos que no deben de ser ni nulos ni estar en blanco
    public class ColaAtencionValidacion : AbstractValidator<ColaAtencionRequestDto>
    {
        public ColaAtencionValidacion()
        {
            RuleFor(x => x.ProblemaReportado)
                .NotNull().WithMessage("El campo de problema reportado no puede ser nulo.")
                .NotEmpty().WithMessage("El campos problema reportado no puede ser vacío.");
            RuleFor(x => x.CodCliente)
                .NotNull().WithMessage("El código del cliente es necesario.")
                .NotEmpty().WithMessage("El código del cliente no puede ser vacío.");
        }
    }
}
