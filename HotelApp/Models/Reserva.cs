namespace HotelApp.Models;

public class Reserva
{
    public Quarto Quarto { get; set; } = new Quarto();
    public int Adultos { get; set; }
    public int Criancas { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public int Diarias => Math.Max(1, (CheckOut.Date - CheckIn.Date).Days);

    public double ValorDiaria =>
        (Adultos * Quarto.ValorDiariaAdulto) + (Criancas * Quarto.ValorDiariaCrianca);

    public double ValorTotal => ValorDiaria * Diarias;
}