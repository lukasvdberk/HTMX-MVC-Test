namespace HTMX_MVC_Test.Models;

public class FormValueResult
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}