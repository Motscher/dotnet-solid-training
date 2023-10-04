namespace DevBasics.CarManagement
{
    public interface ICarPoolNumbeGenerator
    {
        void Generate(string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber);
    }
}