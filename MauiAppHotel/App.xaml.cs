﻿using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
              new Quarto()
              {
               Descricao = "Evento Super Luxo",
               ValorDiariaAdulto = 110.0,
               ValorDiariaCrianca = 55.0
              },
              new Quarto()
              {
               Descricao = "Evento Luxo",
               ValorDiariaAdulto = 80.0,
               ValorDiariaCrianca = 40.0
              },
              new Quarto()
              {
               Descricao = "Evento Simples",
               ValorDiariaAdulto = 50.0,
               ValorDiariaCrianca = 25.0
              },
              new Quarto()
              {
               Descricao = "Evento Basico",
               ValorDiariaAdulto = 25.0,
               ValorDiariaCrianca = 12.5
              },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

              protected override Window CreateWindow(IActivationState? activationState)
              {
                var window = base.CreateWindow(activationState);

                window.Width = 400;
                window.Height = 800;

                return window;
              }
    }
}