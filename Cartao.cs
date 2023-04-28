using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_system
{
	public abstract class Cartao : Pagamento
	{
		public string Bandeira;
		public string NumeroCartao;
		public string Titular;
		public string Cvv;
		
		public abstract void Pagar();
		public abstract string SalvarCartao();
	}
}