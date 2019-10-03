using System;

namespace Builder
{
    class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder()
        {
            this.celular = new Celular("IPhone");
        }
        public Celular Celular
        {
            get { return this.celular; }
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16 mp";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "IOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "9";
        }
    }
}
