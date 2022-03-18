using System;

namespace ENCONTROREMOTO3
{
    public class Endereco
    {
        public string? logradouro { get; set; }
        public int numero { get; set; }
        public string? complemento { get; set; }
        public bool enderecoComercial { get; set; }

        public static implicit operator string(Endereco v)
        {
            throw new NotImplementedException();
        }
    }
}