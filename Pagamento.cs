using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_system
{
	public class Pagamento
	{
		public float Valor;
		private DateTime Data;
		
		public Pagamento() 
		{
			Data = DateTime.Now;
		}
		
		public string Cancelar() 
		{
			Valor = 0;
			return "Pagamento cancelado!";
		}
	}
}