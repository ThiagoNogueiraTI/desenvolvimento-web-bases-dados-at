namespace at.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int PacoteTuristicoId { get; set; }
        public PacoteTuristico PacoteTuristico { get; set; }
        public DateTime DataReserva { get; set; }

        public event Action<string> CapacityReached;

        public void CheckCapacity(int totalReservations)
        {
            if (PacoteTuristico != null && totalReservations > PacoteTuristico.CapacidadeMaxima)
            {
                CapacityReached?.Invoke("Limite de 5 reservas do pacote foi ultrapassado!");
            } else
            {
                CapacityReached?.Invoke("Reserva registrada");
            }
        }
    }
}
