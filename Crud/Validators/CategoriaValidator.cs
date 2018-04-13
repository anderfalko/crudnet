using Crud.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty() 
                .NotNull()
                .Length(3, 100);

            RuleFor(x => x.Referencia)
                .Length(3, 100);
        }
    }
}
