namespace CsharpFirstProject.InterfaceLesson
{
    internal interface ICustomerModel
    {
        string City { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string StreetAddress { get; set; }
    }
}