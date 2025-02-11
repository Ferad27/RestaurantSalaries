using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantSalaries.Entities
{
    public class Salary
    {
        public int Id { get; set; }

        [Column("СлужителId")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Column("Почасова Ставка")]
        public decimal HourlyRate { get; set; }

        [Column("Отработени Часове")]
        public int HoursWorked { get; set; }

        [Column("Бонус")]
        public decimal Bonus { get; set; }

        [Column("Удръжки")]
        public decimal Deductions { get; set; }

        [Column("Основна Заплата")]
        public decimal BaseSalary { get; set; }

        [Column("Общо Заплата")]
        public decimal TotalSalary { get; set; }

        [Column("Дата на получаване")]
        public DateTime DateSalaryRecieved { get; set; }
    }
}