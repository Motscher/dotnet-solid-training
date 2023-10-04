using DevBasics.CarManagement.Dependencies;
using System;

namespace DevBasics.CarManagement
{
    abstract public class CarPoolNumberGeneratorBase : ICarPoolNumbeGenerator
    {
        public void Generate(string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber)
        {
            registrationRegistrationId = GenerateRegistrationRegistrationId();
            registrationNumber = GenerateRegistrationNumber(endCustomerRegistrationReference, registrationRegistrationId);
        }

        private string GenerateRegistrationRegistrationId()
        {
            return DateTime.Now.Ticks.ToString();
        }
        protected abstract string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId);
    }
}