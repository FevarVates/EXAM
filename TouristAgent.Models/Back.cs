﻿namespace TouristAgent.Models;

using System.ComponentModel.DataAnnotations;

public class Back
{
    [Key] public int Id { get; set; }
    [Required(ErrorMessage ="Введите кол-во звёзд" )]public int Stars { get; set; }
    [Required (ErrorMessage = "Текс обязателен")] public string Text { get; set; }
}