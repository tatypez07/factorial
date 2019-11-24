using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TipFactorial.Core.Services;

namespace TipFactorial.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly IFactorialService _FactorialService;
       
        private double _numero;
        

        public TipViewModel(IFactorialService FactorialService)
        {
            _FactorialService = FactorialService;
        }

        public double numero
        {
            get => _numero;
            set
            {
                _numero = value;
               
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            numero = 0;            
           
        }

      
    }
}

