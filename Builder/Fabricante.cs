﻿using System;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildTela();
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildCamera();
        }
    }
}
