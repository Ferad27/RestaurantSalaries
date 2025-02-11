using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantSalaries.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Column("Име")]
        [DisplayName("Име")]
        public string Name { get; set; }

        [Column("Длъжност")]
        [DisplayName("Длъжност")]
        public string Position { get; set; }

        [Column("Почасова ставка")]
        [DisplayName("Почасова ставка")]
        public decimal HourlyRate { get; set; }

        [Column("Отработени часове")]
        [DisplayName("Отработени часове")]
        public int HoursWorked { get; set; }

        [Column("Бонус")]
        [DisplayName("Бонус")]
        public decimal Bonus { get; set; }

        [Column("Удръжки")]
        [DisplayName("Удръжки")]
        public decimal Deductions { get; set; }

        [Column("Заплати")]
        public ICollection<Salary> Salaries { get; set; }
    }
}