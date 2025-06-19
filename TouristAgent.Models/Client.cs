namespace TouristAgent.Models;

using System.ComponentModel.DataAnnotations;

public class Client
{
    [Key] public int Id { get; set; }
    
    [Required(ErrorMessage = "Имя обязательна к заполнению")]public string Name { get; set; }
    [Required(ErrorMessage = "Телефон обязателен к заполнению")]public double Phone { get; set; }
    [Required(ErrorMessage = "Почта обязательнф к заполнению")]public string Email { get; set; }
}
