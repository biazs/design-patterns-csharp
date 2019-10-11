using System;
using System.Collections.Generic;

namespace Observer
{
    class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            _nome = nome;            
            _assunto = assunto;
        }

        public override void Update()
        {
            this._estadoObservador = this._assunto.EstadoAssunto;
            Console.WriteLine("Observador '{0}' seu novo estado e: {1}", this._nome, this._estadoObservador);
        }
        public AssuntoConcreto Assunto   { get; set; }
    }
}
