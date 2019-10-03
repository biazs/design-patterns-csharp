using System;

namespace Builder
{
    class AndroidBuilder : ICelular
    {
        Celular celular;
        public AndroidBuilder()
        {
            this.celular = new Celular("Android");
        }
        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15 mp";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this.celular.tela = "7";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }
}
