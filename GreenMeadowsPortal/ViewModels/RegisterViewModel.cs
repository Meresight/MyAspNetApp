﻿namespace GreenMeadowsPortal.ViewModels;
using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Address { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }

    [Required, DataType(DataType.Password), Compare("Password")]
    public string ConfirmPassword { get; set; }
}
