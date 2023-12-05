using System.ComponentModel.DataAnnotations;
using WorkHourCalculator.Domain.Enums;

namespace WorkHourCalculator.Domain
{
    public class Worker
    {
        [Key]
        public int Matricula { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public int HoraExtra { get; set; }
        public TypeOfDay TypeOfDay { get; set; }
        public string ServiceId { get; set; }
        public ICollection<WorkerService> Services { get; set; }
        public WorkScale WorkScale { get; set; }

        public Worker(int matricula,
                      string firstName,
                      string lastName,
                      DateTime horaInicial,
                      DateTime horaFinal,
                      TypeOfDay typeOfDay,
                      ICollection<Service> services,
                      WorkScale workScale)
        {
            Matricula = matricula;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            FullName = firstName + lastName;
            HoraInicial = horaInicial;
            HoraFinal = horaFinal;
            TypeOfDay = typeOfDay;
            Services = services;
            WorkScale = workScale;
        }
    }
}
