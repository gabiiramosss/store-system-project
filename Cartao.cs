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
		public string SalvarCartao(string bandeira, string numeroCartao, string titular, string cvv) 
		{
			Bandeira = bandeira;
			NumeroCartao = numeroCartao;
			Titular = titular;
			Cvv = cvv;
			
			return $"O cartão foi salvo com a bandeira {bandeira}, número de cartão {NumeroCartao} , titular {Titular} e CVV {Cvv}";
		} 
	}
}